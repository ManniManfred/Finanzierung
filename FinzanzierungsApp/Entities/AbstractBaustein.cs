using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinzanzierungsApp
{
    public class AbstractBaustein : IBaustein
    {
        public AbstractBaustein()
        {
        }

        public event EventHandler SmthChanged;

        private IBaustein parentBaustein;

        [Category("Angaben")]
        [ReadOnly(true)]
        [DisplayName("Anschlussf. von")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public IBaustein ParentBaustein
        {
            get
            {
                return parentBaustein;
            }
            set
            {
                if (parentBaustein != value)
                {
                    if (parentBaustein != null)
                    {
                        parentBaustein.SmthChanged -= ParentBaustein_SmthChanged;
                    }

                    parentBaustein = value;

                    if (parentBaustein != null)
                    {
                        Rate = parentBaustein.Rate;
                        ZinsenProJahr = parentBaustein.ZinsenProJahr;
                        TakeFromParentBaustein();
                        parentBaustein.SmthChanged += ParentBaustein_SmthChanged;
                    }

                }
            }
        }


        [Category("Angaben")]
        public List<SonderTilgung> SonderTilgungen { get; set; }

        [Browsable(false)]
        public string Title { get; set; }

        [Category("Angaben")]
        public double Auszahlung { get; set; }

        [Category("Angaben")]
        public double ZinsenProJahr { get; set; }

        [Category("Angaben")]
        public double Rate { get; set; }

        [Category("Angaben")]
        public int Laufzeit { get; set; }

        [Category("Angaben")]
        public int KeineTilgung { get; set; }

        [Category("Angaben")]
        public DateTime StartDatum { get; set; }

        [Category("Angaben")]
        public bool Unsicher { get; set; }

        [Browsable(false)]
        public double Gesamt { get; protected set; }
        [Browsable(false)]
        public double RestSchuld { get; protected set; }
        [Browsable(false)]
        public int Monate { get; protected set; }
        [Browsable(false)]
        public double GezahlteZinsen { get; protected set; }

        [Category("Ergebnis")]
        public DateTime EndDatum { get; protected set; }


        [Category("Ergebnis")]
        public string Gesamtkosten => Gesamt.ToString("C");

        [Category("Ergebnis")]
        [DisplayName("Restschuld")]
        public string RestSchuldText => RestSchuld.ToString("C");

        [Category("Ergebnis")]
        public string Dauer => "" + (Monate / 12) + " Jahre " + (Monate % 12) + " Monate";

        [Category("Ergebnis")]
        [DisplayName("Gezahlte Zinsen")]
        public string GezahlteZinsenText => GezahlteZinsen.ToString("C");

        public override string ToString()
        {
            return "Baustein: " + Title;
        }

        protected void FireSmthChanged()
        {
            SmthChanged?.Invoke(this, EventArgs.Empty);
        }

        public virtual void Calc()
        {
        }

        private void ParentBaustein_SmthChanged(object sender, EventArgs e)
        {
            TakeFromParentBaustein();
        }

        protected IEnumerable<SonderTilgung> GetSonderTilgungen(DateTime monat)
        {
            if (SonderTilgungen != null)
            {
                foreach (var ti in SonderTilgungen)
                {
                    if (ti.Datum >= monat && ti.Datum < monat.AddMonths(1))
                        yield return ti;
                }
            }
        }

        public virtual void FromXml(Variante variante, XElement ele)
        {
            Title = ele.GetAttributeValue(nameof(Title), Title);

            string parentBausteinTitle = "";
            parentBausteinTitle = ele.GetAttributeValue(nameof(ParentBaustein), parentBausteinTitle);
            if (!string.IsNullOrEmpty(parentBausteinTitle))
            {
                ParentBaustein = variante.GetBaustein(parentBausteinTitle);
            }

            Auszahlung = ele.GetAttributeValue(nameof(Auszahlung), Auszahlung);
            ZinsenProJahr = ele.GetAttributeValue(nameof(ZinsenProJahr), ZinsenProJahr);
            Rate = ele.GetAttributeValue(nameof(Rate), Rate);
            Laufzeit = ele.GetAttributeValue(nameof(Laufzeit), Laufzeit);
            KeineTilgung = ele.GetAttributeValue(nameof(KeineTilgung), KeineTilgung);
            StartDatum = ele.GetAttributeValue(nameof(StartDatum), StartDatum);
            Unsicher = ele.GetAttributeValue(nameof(Unsicher), Unsicher);

            SonderTilgungen = new List<SonderTilgung>();
            foreach (var xTilgung in ele.Elements("Sondertilgung"))
            {
                var ti = new SonderTilgung();
                ti.FromXml(xTilgung);
                SonderTilgungen.Add(ti);
            }

            Calc();
        }

        public virtual void ToXml(XElement ele)
        {
            ele.Add(new XAttribute(nameof(Title), Title ?? ""));
            ele.Add(new XAttribute(nameof(ParentBaustein), ParentBaustein?.Title ?? ""));
            ele.Add(new XAttribute(nameof(Auszahlung), Auszahlung));
            ele.Add(new XAttribute(nameof(ZinsenProJahr), ZinsenProJahr));
            ele.Add(new XAttribute(nameof(Rate), Rate));
            ele.Add(new XAttribute(nameof(Laufzeit), Laufzeit));
            ele.Add(new XAttribute(nameof(KeineTilgung), KeineTilgung));
            ele.Add(new XAttribute(nameof(StartDatum), StartDatum));
            ele.SetAttributeValue(nameof(Unsicher), Unsicher);

            if (SonderTilgungen != null)
            {
                foreach (var ti in SonderTilgungen)
                {
                    var xTilgung = new XElement("Sondertilgung");
                    ti.ToXml(xTilgung);
                    ele.Add(xTilgung);
                }
            }
        }

        public void TakeFromParentBaustein()
        {
            if (ParentBaustein == null)
                return;

            Auszahlung = ParentBaustein.RestSchuld;
            StartDatum = ParentBaustein.EndDatum;

            Calc();
        }
    }
}
