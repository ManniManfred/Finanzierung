using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Blatt : UserControl
    {
        public Blatt()
        {
            InitializeComponent();
        }

        public double StartSchuld
        {
            get => double.Parse(tbStart.Text);
            set => tbStart.Text = "" + value;
        }

        public double ZinsenProJahr
        {
            get => double.Parse(tbZinsen.Text);
            set => tbZinsen.Text = "" + value;
        }

        public double Rate
        {
            get => double.Parse(tbRate.Text);
            set => tbRate.Text = "" + value;
        }

        public double RestSchuld { get; set; }
        public int Monate { get; set; }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalcMonate();
            }
            catch
            {
            }
        }

        private void CalcMonate()
        {
            var startSchuld = double.Parse(tbStart.Text);
            var zinsenProJahr = double.Parse(tbZinsen.Text) / 100;
            var rate = double.Parse(tbRate.Text);

            var zinsenProMonat = zinsenProJahr / 12;
            var restSchuld = startSchuld;
            int monat = 0;
            while (restSchuld > 0.0 && !double.IsInfinity(restSchuld))
            {
                restSchuld = restSchuld * (1 + zinsenProMonat) - rate;
                monat++;
            }

            tbGesamt.Text = "" + (monat * rate);
            tbDauer.Text = "" + (monat / 12) + " Jahre " + (monat % 12) + " Monate";

            Monate = monat;
            RestSchuld = 0.0;
        }

        //private void CalcRestschuld(int laufzeitInMonate)
        //{
        //    var startSchuld = double.Parse(tbStartSchuld.Text);
        //    var zinsenProJahr = double.Parse(tbZinsen.Text);
        //    var rate = double.Parse(tbRate.Text);
        //
        //    var zinsenProMonat = zinsenProJahr / 12;
        //    var restSchuld = startSchuld;
        //    int monat = 0;
        //    while (restSchuld > 0.0 || monat < laufzeitInMonate)
        //    {
        //        restSchuld = restSchuld * (1 + zinsenProMonat) - rate;
        //        monat++;
        //    }
        //    Monate = monat;
        //    RestSchuld = restSchuld;
        //}

    }
}
