using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinzanzierungsApp
{
    public class SonderTilgung
    {
        public SonderTilgung()
        {
        }

        public DateTime Datum { get; set; }
        public double Betrag { get; set; }

        public void ToXml(XElement ele)
        {
            ele.Add(new XAttribute(nameof(Datum), Datum));
            ele.Add(new XAttribute(nameof(Betrag), Betrag));

        }

        public void FromXml(XElement ele)
        {
            Datum = ele.GetAttributeValue(nameof(Datum), Datum);
            Betrag = ele.GetAttributeValue(nameof(Betrag), Betrag);
        }

        public override string ToString()
        {
            return Datum.ToString("yyyy-MM-dd") + " " + Betrag.ToString("N2") + " €";
        }
    }
}
