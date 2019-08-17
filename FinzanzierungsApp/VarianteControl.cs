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
    public partial class VarianteControl : UserControl
    {
        public VarianteControl(Variante variante)
        {
            InitializeComponent();

            this.Variante = variante;

            UpdateGui();
        }

        public Variante Variante { get; }

        public string Title
        {
            get => Variante.Title;
            set => Variante.Title = value;
        }

        public void UpdateGui()
        {
            foreach (var b in Variante.GetBausteine())
            {
                AddBausteinCtrl(b);
            }

            tbTitle.Text = Title;
            CalcSummen();
        }

        private void CalcSummen()
        {
            Variante.CalcSummen();

            tbStart.Text = Variante.Auszahlung.ToString("N2");
            tbRate.Text = Variante.Rate.ToString("N2");
            tbGezahlteZinsen.Text = Variante.GezahlteZinsen.ToString("N2");
            tbGesamt.Text = Variante.Gesamt.ToString("N2");
            tbDauer.Text = Variante.GesamtLaufzeit;

            tbUnsicherheit.Text = Variante.Unsicherheit;
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
            Variante.AddBaustein(baustein);

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
            Variante.RemoveBaustein(baustein?.Baustein);
            flowPanel.Controls.Remove(baustein);
            baustein.SmthChanged -= Baustein_SmthChanged;
        }


        private void Baustein_SmthChanged(object sender, EventArgs e)
        {
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
