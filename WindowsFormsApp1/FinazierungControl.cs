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
        private List<BausteinControl> bausteine = new List<BausteinControl>();

        public FinazierungControl()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => tbTitle.Text;
            set => tbTitle.Text = value;
        }

        private void CalcSummen()
        {
            double auszahlung = 0.0;
            double rate = 0.0;
            double gezahlteZinsen = 0.0;
            int monate = 0;

            foreach(var baustein in bausteine)
            {
                auszahlung += baustein.Auszahlung;
                rate += baustein.Rate;
                gezahlteZinsen += baustein.GezahlteZinsen;
                monate = Math.Max(baustein.Monate, monate);
            }

            tbStart.Text = auszahlung.ToString("N2");
            tbRate.Text = rate.ToString("N2");
            tbGezahlteZinsen.Text = gezahlteZinsen.ToString("N2");

            tbDauer.Text = "" + (monate / 12) + " Jahre " + (monate % 12) + " Monate";
        }

        private void BtAddBaustein_Click(object sender, EventArgs e)
        {
            AddBaustein();
        }

        private void BtRefresh_Click(object sender, EventArgs e)
        {
            CalcSummen();
        }

        private BausteinControl AddBaustein()
        {
            var baustein = new BausteinControl();
            bausteine.Add(baustein);
            flowPanel.Controls.Add(baustein);

            baustein.SmthChanged += Baustein_SmthChanged;
            return baustein;
        }


        private void RemoveBaustein(BausteinControl baustein)
        {
            bausteine.Remove(baustein);
            flowPanel.Controls.Remove(baustein);
            baustein.SmthChanged -= Baustein_SmthChanged;
        }

        private void Baustein_SmthChanged(object sender, EventArgs e)
        {
            CalcSummen();
        }

        public void ToXml(XElement xFinazierung)
        {
            xFinazierung.Add(new XAttribute(nameof(Title), Title));
            foreach (var baustein in bausteine)
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
