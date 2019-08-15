using System;
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

namespace FinzanzierungsApp
{
    public partial class FinzanzierungsForm : Form
    {
        private const string FILENAME = "Daten.xml";

        private List<FinazierungControl> varianten = new List<FinazierungControl>();

        public FinzanzierungsForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (File.Exists(FILENAME))
                LoadData(FILENAME);
        }

        private FinazierungControl AddVariante()
        {
            var variante = new FinazierungControl();
            variante.Dock = DockStyle.Fill;
            varianten.Add(variante);

            var page = new TabPage();
            page.Controls.Add(variante);
            tabs.TabPages.Add(page);

            return variante;
        }

        private void RemoveVariante(FinazierungControl variante)
        {
            varianten.Remove(variante);
            tabs.TabPages.Remove(variante.Parent as TabPage);
        }

        private void SaveData(string fileName)
        {
            XDocument doc = new XDocument(new XElement("Daten"));

            foreach(var variante in varianten)
            {
                var xVariante = new XElement("Variante");
                doc.Root.Add(xVariante);
                variante.ToXml(xVariante);
            }

            doc.Save(fileName);
        }

        private void LoadData(string fileName)
        {
            tabs.TabPages.Clear();

            var doc = XDocument.Load(fileName);
            
            foreach(var xVariante in doc.Root.Elements("Variante"))
            {
                var variante = AddVariante();
                variante.FromXml(xVariante);
            }

            UpdateGUI();
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
            AddVariante();
        }

        private void BtRemove_Click(object sender, EventArgs e)
        {
            if (tabs.SelectedTab == null || tabs.SelectedTab.Controls.Count <= 0)
                return;

            var variante = tabs.SelectedTab.Controls[0] as FinazierungControl;
            if (MessageBox.Show($"Variante {variante.Title} löschen?", "Löschen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                 == DialogResult.Yes)
            {
                RemoveVariante(variante);
            }
        }

        private void TbAnschlussZins_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(tbAnschlussZins.Text, out double anschlussZins))
                return;

            foreach(var v in varianten)
            {
                foreach(var b in v.Finanzierung.GetBausteine())
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
            var variants = new List<Finanzierung>();
            double anschlussZins = 0.0;
            foreach (var v in varianten)
            {
                variants.Add(v.Finanzierung);

                foreach (var b in v.Finanzierung.GetBausteine())
                {
                    if (b.Unsicher)
                    {
                        anschlussZins = Math.Max(b.ZinsenProJahr, anschlussZins);
                    }
                }
            }
            tbAnschlussZins.Text = anschlussZins.ToString("N2");

            dataGridView1.DataSource = variants;
        }
    }
}
