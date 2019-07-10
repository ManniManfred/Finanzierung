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
        public event EventHandler SmthChanged;
        private BausteinControl parentBaustein;

        public BausteinControl(FinazierungControl finazierung)
        {
            InitializeComponent();
            Finazierung = finazierung;

            sonderTilgungControl1.Tilgungs.ListChanged += Tilgungs_ListChanged;
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
                double.TryParse(tbAuszahlung.Text, out double result);
                return result;
            }
            set => tbAuszahlung.Text = value.ToString("N2");
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

        public int KeineTilgung
        {
            get
            {
                int.TryParse(tbKeineTilgung.Text, out int result);
                return result;
            }
            set => tbKeineTilgung.Text = "" + value;
        }

        public DateTime StartDatum
        {
            get => startDate.Value;
            set => startDate.Value = value;
        }

        public double RestSchuld { get; set; }
        public int Monate { get; set; }
        public double GezahlteZinsen { get; set; }
        public DateTime EndDatum { get; set; }
        public FinazierungControl Finazierung { get; }

        public BausteinControl ParentBaustein
        {
            get
            {
                return parentBaustein;
            }
            set
            {
                if (parentBaustein != null)
                {
                    parentBaustein.SmthChanged -= ParentBaustein_SmthChanged;
                }
                parentBaustein = value;

                tbAnschluss.Text = parentBaustein?.Title;
                tbAuszahlung.ReadOnly = parentBaustein != null;
                tbRate.ReadOnly = parentBaustein != null;

                if (ParentBaustein != null)
                {
                    ParentBaustein.SmthChanged += ParentBaustein_SmthChanged;
                }

                TakeFromParent();
            }
        }

        private void ParentBaustein_SmthChanged(object sender, EventArgs e)
        {
            TakeFromParent();
        }

        private void TakeFromParent()
        {
            if (ParentBaustein == null)
                return;

            Auszahlung = ParentBaustein.RestSchuld;
            Rate = ParentBaustein.Rate;
            StartDatum = ParentBaustein.EndDatum;
        }

        private void Tilgungs_ListChanged(object sender, ListChangedEventArgs e)
        {
            try
            {
                CalcMonate();
            }
            catch
            {
            }
        }

        private void InputValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalcMonate();
            }
            catch
            {
            }
        }

        private IEnumerable<SonderTilgung> GetSonderTilgungen(DateTime monat)
        {
            foreach (var ti in sonderTilgungControl1.Tilgungs)
            {
                if (ti.Datum >= monat && ti.Datum < monat.AddMonths(1))
                    yield return ti;
            }
        }

        private void CalcMonate()
        {
            var startSchuld = Auszahlung;
            var zinsenProJahr = ZinsenProJahr / 100;
            var rate = Rate;
            var laufzeitInMonate = Laufzeit * 12;
            var keineTilgungMonate = KeineTilgung * 12;

            var zinsenProMonat = zinsenProJahr / 12;
            var restSchuld = startSchuld;
            double gesamt = 0.0;
            double gezahlteZinsen = 0.0;
            int monat = 0;

            //sonderTilgungControl1.Tilgungs

            if (startSchuld != 0.0 || zinsenProJahr != 0.0 || rate != 0.0)
            {
                while (restSchuld > 0.0
                    && !double.IsInfinity(restSchuld)
                    && (laufzeitInMonate == 0 || monat < laufzeitInMonate))
                {
                    foreach (var ti in GetSonderTilgungen(StartDatum.AddMonths(monat)))
                    {
                        restSchuld -= ti.Betrag;
                    }

                    if (monat >= keineTilgungMonate)
                    {
                        gezahlteZinsen += restSchuld * zinsenProMonat;

                        if (restSchuld <= rate)
                        {
                            gesamt += restSchuld;
                            restSchuld = 0.0;
                        }
                        else
                        {
                            restSchuld = restSchuld * (1 + zinsenProMonat) - rate;
                            gesamt += rate;
                        }
                        if (restSchuld >= startSchuld)
                            break;
                    }
                    else
                    {
                        gezahlteZinsen += restSchuld * zinsenProMonat;
                        gesamt += restSchuld * zinsenProMonat;
                    }
                    monat++;
                }
            }

            Monate = monat;
            RestSchuld = restSchuld;
            GezahlteZinsen = gezahlteZinsen;
            EndDatum = StartDatum.AddMonths(monat);

            tbGesamt.Text = "" + gesamt.ToString("N2");
            tbGezahlteZinsen.Text = (gezahlteZinsen).ToString("N2");
            tbRestSchuld.Text = restSchuld.ToString("N2");

            tbDauer.Text = "" + (monat / 12) + " Jahre " + (monat % 12) + " Monate";
            tbEnde.Text = EndDatum.ToString();

            SmthChanged?.Invoke(this, EventArgs.Empty);
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
            ele.Add(new XAttribute(nameof(ParentBaustein), ParentBaustein?.Title ?? ""));
            ele.Add(new XAttribute(nameof(Auszahlung), Auszahlung));
            ele.Add(new XAttribute(nameof(ZinsenProJahr), ZinsenProJahr));
            ele.Add(new XAttribute(nameof(Rate), Rate));
            ele.Add(new XAttribute(nameof(Laufzeit), Laufzeit));
            ele.Add(new XAttribute(nameof(KeineTilgung), KeineTilgung));
            ele.Add(new XAttribute(nameof(StartDatum), StartDatum));

            foreach (var ti in sonderTilgungControl1.Tilgungs)
            {
                var xTilgung = new XElement("Sondertilgung");
                ti.ToXml(xTilgung);
                ele.Add(xTilgung);
            }
        }

        public void FromXml(XElement ele)
        {
            Title = ele.GetAttributeValue(nameof(Title), Title);

            string parentBausteinTitle = "";
            parentBausteinTitle = ele.GetAttributeValue(nameof(ParentBaustein), parentBausteinTitle);
            if (!string.IsNullOrEmpty(parentBausteinTitle))
            {
                foreach (var b in Finazierung.Bausteine)
                {
                    if (b.Title == parentBausteinTitle)
                    {
                        ParentBaustein = b;
                        break;
                    }
                }
            }

            Auszahlung = ele.GetAttributeValue(nameof(Auszahlung), Auszahlung);
            ZinsenProJahr = ele.GetAttributeValue(nameof(ZinsenProJahr), ZinsenProJahr);
            Rate = ele.GetAttributeValue(nameof(Rate), Rate);
            Laufzeit = ele.GetAttributeValue(nameof(Laufzeit), Laufzeit);
            KeineTilgung = ele.GetAttributeValue(nameof(KeineTilgung), KeineTilgung);
            StartDatum = ele.GetAttributeValue(nameof(StartDatum), StartDatum);

            foreach (var xTilgung in ele.Elements("Sondertilgung"))
            {
                var ti = new SonderTilgung();
                ti.FromXml(xTilgung);
                sonderTilgungControl1.Tilgungs.Add(ti);
            }
        }

        private void BtRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Baustein {this.Title} wirklich  Löschen?", "Löschen", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                Finazierung.RemoveBaustein(this);
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            Finazierung.AddBaustein();
        }

        private void BtAnschluss_Click(object sender, EventArgs e)
        {
            var anschluss = Finazierung.AddBaustein();
            anschluss.ParentBaustein = this;
            anschluss.Title = "-> " + Title;
        }
    }
}
