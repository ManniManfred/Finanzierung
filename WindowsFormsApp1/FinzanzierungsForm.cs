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

        private List<FinazierungControl> blaetter = new List<FinazierungControl>();

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
            blaetter.Add(variante);

            var page = new TabPage();
            page.Controls.Add(variante);
            tabs.TabPages.Add(page);

            return variante;
        }

        private void SaveData(string fileName)
        {
            XDocument doc = new XDocument(new XElement("Daten"));

            foreach(var baustein in blaetter)
            {
                var xBaustein = new XElement("Variante");
                doc.Root.Add(xBaustein);
                baustein.ToXml(xBaustein);
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
    }
}
