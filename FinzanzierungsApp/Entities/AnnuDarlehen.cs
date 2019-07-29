using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinzanzierungsApp
{
    public class AnnuDarlehen : IBaustein
    {
        [Browsable(false)]
        public IBaustein ParentBaustein { get; set; }

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


        [Browsable(false)]
        public double Gesamt { get; private set; }
        [Browsable(false)]
        public double RestSchuld { get; private set; }
        [Browsable(false)]
        public int Monate { get; private set; }
        [Browsable(false)]
        public double GezahlteZinsen { get; private set; }

        [Category("Ergebnis")]
        public DateTime EndDatum { get; private set; }


        [Category("Ergebnis")]
        public string Gesamtkosten => Gesamt.ToString("C");

        [Category("Ergebnis")]
        public string RestSchuldText => RestSchuld.ToString("C");

        [Category("Ergebnis")]
        public string Dauer => "" + (Monate / 12) + " Jahre " + (Monate % 12) + " Monate";

        [Category("Ergebnis")]
        public string GezahlteZinsenText => GezahlteZinsen.ToString("C");

        private IEnumerable<SonderTilgung> GetSonderTilgungen(DateTime monat)
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

        public void Calc()
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
            Gesamt = gesamt;
        }


        public void ToXml(XElement ele)
        {
            ele.Add(new XAttribute(nameof(Title), Title ?? ""));
            ele.Add(new XAttribute(nameof(ParentBaustein), ParentBaustein?.Title ?? ""));
            ele.Add(new XAttribute(nameof(Auszahlung), Auszahlung));
            ele.Add(new XAttribute(nameof(ZinsenProJahr), ZinsenProJahr));
            ele.Add(new XAttribute(nameof(Rate), Rate));
            ele.Add(new XAttribute(nameof(Laufzeit), Laufzeit));
            ele.Add(new XAttribute(nameof(KeineTilgung), KeineTilgung));
            ele.Add(new XAttribute(nameof(StartDatum), StartDatum));

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

        public void FromXml(Finanzierung finazierung, XElement ele)
        {
            Title = ele.GetAttributeValue(nameof(Title), Title);

            string parentBausteinTitle = "";
            parentBausteinTitle = ele.GetAttributeValue(nameof(ParentBaustein), parentBausteinTitle);
            if (!string.IsNullOrEmpty(parentBausteinTitle))
            {
                finazierung.GetBaustein(parentBausteinTitle);
            }

            Auszahlung = ele.GetAttributeValue(nameof(Auszahlung), Auszahlung);
            ZinsenProJahr = ele.GetAttributeValue(nameof(ZinsenProJahr), ZinsenProJahr);
            Rate = ele.GetAttributeValue(nameof(Rate), Rate);
            Laufzeit = ele.GetAttributeValue(nameof(Laufzeit), Laufzeit);
            KeineTilgung = ele.GetAttributeValue(nameof(KeineTilgung), KeineTilgung);
            StartDatum = ele.GetAttributeValue(nameof(StartDatum), StartDatum);

            SonderTilgungen = new List<SonderTilgung>();
            foreach (var xTilgung in ele.Elements("Sondertilgung"))
            {
                var ti = new SonderTilgung();
                ti.FromXml(xTilgung);
                SonderTilgungen.Add(ti);
            }
        }

    }
}
