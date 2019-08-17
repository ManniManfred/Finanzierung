﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Be.Timvw.Framework.ComponentModel;

namespace FinzanzierungsApp
{
    public partial class FinzanzierungsForm : Form
    {
        private const string FILENAME = "Daten.xml";

        private Vergleich vergleich = new Vergleich();

        private Dictionary<Variante, TabPage> varianteToPage = new Dictionary<Variante, TabPage>();

        public FinzanzierungsForm()
        {
            InitializeComponent();

            this.dataGridView1.DataSource = vergleich.Variants;

            //dataGridView1.DataBindingComplete += MakeColumnsSortable_DataBindingComplete;
            //vergleich.Variants.AddingNew += Variants_AddingNew;

            vergleich.Variants.ListChanged += Variants_ListChanged;
        }

        private void Variants_ListChanged(object sender, ListChangedEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemChanged:
                    break;
                case ListChangedType.ItemAdded:
                case ListChangedType.ItemDeleted:
                case ListChangedType.Reset:

                    var toRemove = new HashSet<Variante>(varianteToPage.Keys);

                    foreach (var v in vergleich.Variants)
                    {
                        toRemove.Remove(v);
                        if (!varianteToPage.TryGetValue(v, out var page))
                        {
                            AddCtrlFor(v);
                        }
                    }

                    foreach(var v in toRemove)
                    {
                        RemoveCtrlFor(v);
                    }

                    break;
            }

            //UpdateGUI();
        }

        private void Variants_AddingNew(object sender, AddingNewEventArgs e)
        {
            e.NewObject = new Variante();
        }

        void MakeColumnsSortable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //Add this as an event on DataBindingComplete
            DataGridView dataGridView = sender as DataGridView;
            if (dataGridView == null)
            {
                var ex = new InvalidOperationException("This event is for a DataGridView type senders only.");
                ex.Data.Add("Sender type", sender.GetType().Name);
                throw ex;
            }

            foreach (DataGridViewColumn column in dataGridView.Columns)
                column.SortMode = DataGridViewColumnSortMode.Automatic;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (File.Exists(FILENAME))
                LoadData(FILENAME);
        }

        private VarianteControl AddCtrlFor(Variante v)
        {
            var variante = new VarianteControl(v);
            variante.Dock = DockStyle.Fill;

            var page = new TabPage();
            page.Text = v.Title;
            page.Controls.Add(variante);
            tabs.TabPages.Add(page);

            varianteToPage.Add(v, page);
            return variante;
        }

        private void RemoveCtrlFor(Variante variante)
        {
            if (varianteToPage.TryGetValue(variante, out var page))
            {
                tabs.TabPages.Remove(page);
                varianteToPage.Remove(variante);
            }
        }

        private void SaveData(string fileName)
        {
            XDocument doc = new XDocument(new XElement("Daten"));
            vergleich.ToXml(doc.Root);

            doc.Save(fileName);
        }

        private void LoadData(string fileName)
        {
            var doc = XDocument.Load(fileName);
            vergleich.FromXml(doc.Root);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            var dialogResult = MessageBox.Show("Soll gespeichert werden?", "Speichern", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                SaveData(FILENAME);
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            SaveData(FILENAME);
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            vergleich.Variants.AddNew();
        }

        private void BtRemove_Click(object sender, EventArgs e)
        {
            if (tabs.SelectedTab == null || tabs.SelectedTab.Controls.Count <= 0)
                return;

            var ctrl = tabs.SelectedTab.Controls[0] as VarianteControl;
            if (MessageBox.Show($"Variante {ctrl.Title} löschen?", "Löschen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                 == DialogResult.Yes)
            {
                vergleich.Variants.Remove(ctrl.Variante);
            }
        }

        private void TbAnschlussZins_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(tbAnschlussZins.Text, out double anschlussZins))
                return;

            foreach (var v in vergleich.Variants)
            {
                foreach (var b in v.GetBausteine())
                {
                    if (b.Unsicher)
                    {
                        b.ZinsenProJahr = anschlussZins;
                        b.Calc();
                    }
                }
            }
        }

        private void UpdateGUI()
        {
            double anschlussZins = 0.0;
            foreach (var v in vergleich.Variants)
            {
                foreach (var b in v.GetBausteine())
                {
                    if (b.Unsicher)
                    {
                        anschlussZins = Math.Max(b.ZinsenProJahr, anschlussZins);
                    }
                }
            }
            tbAnschlussZins.Text = anschlussZins.ToString("N2");
        }
    }
}
