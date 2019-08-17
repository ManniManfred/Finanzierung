using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace FinzanzierungsApp
{
    public class Variante : INotifyPropertyChanged
    {

        private List<IBaustein> bausteine = new List<IBaustein>();
        private Dictionary<string, IBaustein> titleToBaustein;

        private string title;

        public event PropertyChangedEventHandler PropertyChanged;

        public Variante()
        {
        }

        public string Title
        {
            get => title;
            set => SetPropertyValue(ref title, value);
        }

        public double Gesamt { get; private set; }
        public double GezahlteZinsen { get; private set; }

        [Browsable(false)]
        public int Dauer { get; private set; }

        [DisplayName("Laufzeit")]
        public string GesamtLaufzeit => "" + (this.Dauer / 12) + " Jahre " + (this.Dauer % 12) + " Monate";


        public double UnsicherheitKennzahl { get; private set; }
        public string Unsicherheit { get; private set; }

        public double Auszahlung { get; private set; }

        public double Rate { get; private set; }

        private void SetPropertyValue<T>(ref T member, T newValue, [CallerMemberName]string propName = null)
            where T : class
        {
            if (member != newValue)
            {
                member = newValue;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
            }
        }

        
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

            CalcUnsichertheit();

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Auszahlung)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Rate)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(GezahlteZinsen)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Gesamt)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Dauer)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UnsicherheitKennzahl)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Unsicherheit)));
        }

        private void CalcUnsichertheit()
        {

            string unsicherText = "";
            double unsicherheitKennzahl = 0.0;
            double unsicherheitSumme = 0.0;

            foreach (var b in GetBausteine())
            {
                if (b.Unsicher)
                {
                    unsicherText += $"{b.Auszahlung.ToString("C")} - nach {b.StartDatum.Year - 1} Jahre - {b.ToString()}\r\n";
                    unsicherheitKennzahl += b.Auszahlung * b.Auszahlung / (b.StartDatum.Year - 1) / 10000 / 10000;
                    unsicherheitSumme += b.Auszahlung;
                }
            }

            UnsicherheitKennzahl = unsicherheitKennzahl;
            Unsicherheit = unsicherheitKennzahl.ToString("N2")
                + " - " + unsicherheitSumme.ToString("C")
                + "\r\n"
                + unsicherText;
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
