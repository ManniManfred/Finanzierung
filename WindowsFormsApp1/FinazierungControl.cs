using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinzanzierungsApp
{
    public partial class FinazierungControl : UserControl
    {
        private List<BausteinControl> blaetter = new List<BausteinControl>();

        public FinazierungControl()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => tbTitle.Text;
            set => tbTitle.Text = value;
        }

        private void BtAddBaustein_Click(object sender, EventArgs e)
        {
            AddBaustein();
        }

        private BausteinControl AddBaustein()
        {
            var baustein = new BausteinControl();
            blaetter.Add(baustein);
            flowPanel.Controls.Add(baustein);
            return baustein;
        }

        public void ToXml(XElement xFinazierung)
        {
            xFinazierung.Add(new XAttribute(nameof(Title), Title));
            foreach (var baustein in blaetter)
            {
                var xBaustein = new XElement("Baustein");
                xFinazierung.Add(xBaustein);
                baustein.ToXml(xBaustein);
            }
        }

        public void FromXml(XElement xFinazierung)
        {
            Title = xFinazierung.GetAttributeValue(nameof(Title), Title);
            flowPanel.Controls.Clear();

            foreach (var xBaustein in xFinazierung.Elements("Baustein"))
            {
                var baustein = AddBaustein();
                baustein.FromXml(xBaustein);
            }
        }

        private void TbTitle_TextChanged(object sender, EventArgs e)
        {
            var parent = Parent as TabPage;
            if (parent != null)
                parent.Text = tbTitle.Text;
        }
    }
}
