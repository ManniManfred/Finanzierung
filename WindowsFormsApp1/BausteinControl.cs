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
    public partial class BausteinControl : UserControl
    {
        public BausteinControl()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => tbTitle.Text;
            set => tbTitle.Text = value;
        }

        public double Auszahlung
        {
            get
            {
                double.TryParse(tbStart.Text, out double result);
                return result;
            }
            set => tbStart.Text = "" + value;
        }

        public double ZinsenProJahr
        {
            get
            {
                double.TryParse(tbZinsen.Text, out double result);
                return result;
            }
            set => tbZinsen.Text = "" + value;
        }

        public double Rate
        {
            get
            {
                double.TryParse(tbRate.Text, out double result);
                return result;
            }
            set => tbRate.Text = "" + value;
        }

        public int Laufzeit
        {
            get
            {
                int.TryParse(tbLaufzeit.Text, out int result);
                return result;
            }
            set => tbLaufzeit.Text = "" + value;
        }

        public double RestSchuld { get; set; }
        public int Monate { get; set; }
        public double GezahlteZinsen { get; set; }

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
            var startSchuld = Auszahlung;
            var zinsenProJahr = ZinsenProJahr / 100;
            var rate = Rate;
            var laufzeitInMonate = Laufzeit * 12;

            
            var zinsenProMonat = zinsenProJahr / 12;
            var restSchuld = startSchuld;
            double gezahlteZinsen = 0.0;
            int monat = 0;

            if (startSchuld != 0.0 || zinsenProJahr != 0.0 || rate != 0.0)
            {
                while (restSchuld > 0.0
                    && !double.IsInfinity(restSchuld)
                    && (laufzeitInMonate == 0 || monat < laufzeitInMonate))
                {
                    gezahlteZinsen += restSchuld * zinsenProMonat;
                    restSchuld = restSchuld * (1 + zinsenProMonat) - rate;
                    monat++;

                    if (restSchuld >= startSchuld)
                        break;
                }
            }
            tbGesamt.Text = "" + (monat * rate + restSchuld).ToString("N2");
            tbGezahlteZinsen.Text = (gezahlteZinsen).ToString("N2");
            tbRestSchuld.Text = restSchuld.ToString("N2");

            tbDauer.Text = "" + (monat / 12) + " Jahre " + (monat % 12) + " Monate";

            Monate = monat;
            RestSchuld = restSchuld;
            GezahlteZinsen = gezahlteZinsen;
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

        public void ToXml(XElement ele)
        {
            ele.Add(new XAttribute(nameof(Title), Title));
            ele.Add(new XAttribute(nameof(Auszahlung), Auszahlung));
            ele.Add(new XAttribute(nameof(ZinsenProJahr), ZinsenProJahr));
            ele.Add(new XAttribute(nameof(Rate), Rate));
            ele.Add(new XAttribute(nameof(Laufzeit), Laufzeit));
        }

        public void FromXml(XElement ele)
        {
            Title = ele.GetAttributeValue(nameof(Title), Title);
            Auszahlung = ele.GetAttributeValue(nameof(Auszahlung), Auszahlung);
            ZinsenProJahr = ele.GetAttributeValue(nameof(ZinsenProJahr), ZinsenProJahr);
            Rate = ele.GetAttributeValue(nameof(Rate), Rate);
            Laufzeit = ele.GetAttributeValue(nameof(Laufzeit), Laufzeit);
        }
    }
}
