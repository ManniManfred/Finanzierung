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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string FILENAME = "Daten.xml";

        private List<Blatt> blaetter = new List<Blatt>();

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (File.Exists(FILENAME))
                LoadData(FILENAME);
        }

        private Blatt AddBlatt()
        {
            var blatt = new Blatt();
            blaetter.Add(blatt);
            flowPanel.Controls.Add(blatt);
            return blatt;
        }

        private void SaveData(string fileName)
        {
            XDocument doc = new XDocument(new XElement("Daten"));

            foreach(var blatt in blaetter)
            {
                var xBlatt = new XElement("Blatt");
                doc.Root.Add(xBlatt);
                blatt.ToXml(xBlatt);
            }

            doc.Save(fileName);
        }

        private void LoadData(string fileName)
        {
            flowPanel.Controls.Clear();

            var doc = XDocument.Load(fileName);
            
            foreach(var xBlatt in doc.Root.Elements("Blatt"))
            {
                var blatt = AddBlatt();
                blatt.FromXml(xBlatt);
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            SaveData(FILENAME);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AddBlatt();
        }
    }
}
