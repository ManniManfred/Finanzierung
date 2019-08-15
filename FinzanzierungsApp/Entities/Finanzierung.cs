using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace FinzanzierungsApp
{
    public class Finanzierung
    {
        private List<IBaustein> bausteine = new List<IBaustein>();
        private Dictionary<string, IBaustein> titleToBaustein;

        public Finanzierung()
        {
        }

        public string Title { get; set; }

        public double Auszahlung { get; private set; }
        public double ZinsenProJahr { get; private set; }
        public double Rate { get; private set; }

        public int Dauer { get; private set; }
        public double Gesamt { get; private set; }
        public double GezahlteZinsen { get; private set; }

        
        private void ClearCache()
        {
            titleToBaustein = null;
        }

        public void AddBaustein(IBaustein baustein)
        {
            bausteine.Add(baustein);
            ClearCache();
        }

        public void RemoveBaustein(IBaustein baustein)
        {
            bausteine.Remove(baustein);
            ClearCache();
        }

        public IBaustein GetBaustein(string title)
        {
            if (titleToBaustein == null)
                titleToBaustein = bausteine.ToDictionary(b => b.Title);

            titleToBaustein.TryGetValue(title, out var result);

            return result;
        }

        public IEnumerable<IBaustein> GetBausteine()
        {
            return bausteine;
        }

        public void CalcSummen()
        {
            double auszahlung = 0.0;
            double rate = 0.0;
            double gezahlteZinsen = 0.0;

            DateTime startDate = DateTime.MaxValue;
            DateTime endDate = DateTime.MinValue;

            foreach (var baustein in bausteine)
            {
                if (baustein.ParentBaustein == null)
                {
                    auszahlung += baustein.Auszahlung;
                    rate += baustein.Rate;
                }
                gezahlteZinsen += baustein.GezahlteZinsen;

                startDate = baustein.StartDatum < startDate ? baustein.StartDatum : startDate;
                endDate = baustein.EndDatum > endDate ? baustein.EndDatum : endDate;
            }

            Auszahlung = auszahlung;
            Rate = rate;
            GezahlteZinsen = gezahlteZinsen;
            Gesamt = gezahlteZinsen + auszahlung;

            Dauer = endDate.MonthDifference(startDate);
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

            foreach (var xBaustein in xFinazierung.Elements("Baustein"))
            {
                var baustein = new AnnuDarlehen();
                baustein.FromXml(this, xBaustein);
                this.AddBaustein(baustein);
            }
        }
    }
}
