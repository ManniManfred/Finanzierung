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
        public FinazierungControl()
        {
            InitializeComponent();
        }

        public Finanzierung Finanzierung { get; } = new Finanzierung();

        public string Title
        {
            get => Finanzierung.Title;
            set => Finanzierung.Title = value;
        }

        private void CalcSummen()
        {
            Finanzierung.CalcSummen();

            tbStart.Text = Finanzierung.Auszahlung.ToString("N2");
            tbRate.Text = Finanzierung.Rate.ToString("N2");
            tbGezahlteZinsen.Text = Finanzierung.GezahlteZinsen.ToString("N2");
            tbGesamt.Text = Finanzierung.Gesamt.ToString("N2");
            tbDauer.Text = "" + (Finanzierung.Dauer / 12) + " Jahre " + (Finanzierung.Dauer % 12) + " Monate";
        }

        private void BtAddBaustein_Click(object sender, EventArgs e)
        {
            AddBaustein();
        }

        private void BtRefresh_Click(object sender, EventArgs e)
        {
            CalcSummen();
        }

        public BausteinControl AddBaustein()
        {
            var baustein = new AnnuDarlehen();
            Finanzierung.AddBaustein(baustein);

            return AddBausteinCtrl(baustein);
        }

        public BausteinControl AddBausteinCtrl(IBaustein baustein)
        {
            var ctrl = new BausteinControl(this, baustein);
            flowPanel.Controls.Add(ctrl);

            ctrl.SmthChanged += Baustein_SmthChanged;
            return ctrl;
        }

        public void RemoveBaustein(BausteinControl baustein)
        {
            Finanzierung.RemoveBaustein(baustein?.Baustein);
            flowPanel.Controls.Remove(baustein);
            baustein.SmthChanged -= Baustein_SmthChanged;
        }


        private void Baustein_SmthChanged(object sender, EventArgs e)
        {
            CalcSummen();
        }

        public void ToXml(XElement xVariante)
        {
            Finanzierung.ToXml(xVariante);
        }

        public void FromXml(XElement xVariante)
        {
            Finanzierung.FromXml(xVariante);
            foreach(var b in Finanzierung.GetBausteine())
            {
                AddBausteinCtrl(b);
            }

            tbTitle.Text = Title;
            CalcSummen();
        }

        private void TbTitle_TextChanged(object sender, EventArgs e)
        {
            Title = tbTitle.Text;
            var parent = Parent as TabPage;
            if (parent != null)
                parent.Text = tbTitle.Text;
        }

    }
}
