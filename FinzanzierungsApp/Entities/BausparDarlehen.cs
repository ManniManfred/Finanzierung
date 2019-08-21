using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinzanzierungsApp
{
    public class BausparDarlehen : AbstractBaustein
    {

        [Category("Angaben")]
        public double GuthabensZins { get; set; }

        [Category("Angaben")]
        public double ZuteilungBei { get; set; } = 50; // %

        [Category("Angaben")]
        public double AbschlussGebuehr { get; set; } = 1; // %

        [Category("Angaben")]
        public double GebundenerSollzins { get; set; }

        public override void Calc()
        {
            var kapital = 0.0 - Auszahlung * AbschlussGebuehr / 100;
            var rate = Rate;
            var keineTilgungMonate = KeineTilgung * 12;

            var zinsenProMonat = ZinsenProJahr / 100 / 12;
            var zinsenPhase2 = GebundenerSollzins / 100 / 12;

            var restSchuld = Auszahlung;
            double gesamt = 0.0;
            double gezahlteZinsen = 0.0;
            int monat = 0;

            bool ansparPhase = true;

            //sonderTilgungControl1.Tilgungs

            if (Auszahlung != 0.0 && zinsenProMonat != 0.0 && rate != 0.0)
            {
                while (restSchuld > 0.0
                    && !double.IsInfinity(restSchuld))
                {
                    foreach (var ti in GetSonderTilgungen(StartDatum.AddMonths(monat)))
                    {
                        if (ansparPhase)
                            kapital += ti.Betrag;
                        else
                            restSchuld -= ti.Betrag;
                    }

                    gezahlteZinsen += restSchuld * zinsenProMonat;

                    if (ansparPhase)
                    {
                        if (monat >= keineTilgungMonate)
                        {
                            var restRate = rate - zinsenProMonat;
                            kapital = kapital * (1 + GuthabensZins / 100 / 12) + restRate;

                            gesamt += rate;
                        }
                        else
                        {
                            gesamt += restSchuld * zinsenProMonat;
                        }

                        if (kapital >= Auszahlung * ZuteilungBei / 100)
                        {
                            ansparPhase = false;

                            restSchuld = Auszahlung - kapital;
                        }
                    }
                    else
                    {
                        if (monat >= keineTilgungMonate)
                        {

                            if (restSchuld <= rate)
                            {
                                gesamt += restSchuld;
                                restSchuld = 0.0;
                            }
                            else
                            {
                                restSchuld = restSchuld * (1 + zinsenPhase2) - rate;
                                gesamt += rate;
                            }
                            if (restSchuld >= Auszahlung)
                                break;
                        }
                        else
                        {
                            gesamt += restSchuld * zinsenPhase2;
                        }
                    }
                    monat++;
                }
            }

            //Monate = monat;
            RestSchuld = restSchuld;
            GezahlteZinsen = gezahlteZinsen;
            EndDatum = StartDatum.AddMonths(monat);
            Gesamt = gesamt;

            FireSmthChanged();
        }

        public override void ToXml(XElement ele)
        {
            base.ToXml(ele);
            ele.Add(new XAttribute(nameof(GuthabensZins), GuthabensZins));
            ele.Add(new XAttribute(nameof(ZuteilungBei), ZuteilungBei));
            ele.Add(new XAttribute(nameof(AbschlussGebuehr), AbschlussGebuehr));
            ele.Add(new XAttribute(nameof(GebundenerSollzins), GebundenerSollzins));
        }

        public override void FromXml(Variante variante, XElement ele)
        {
            base.FromXml(variante, ele);

            GuthabensZins = ele.GetAttributeValue(nameof(GuthabensZins), GuthabensZins);
            ZuteilungBei = ele.GetAttributeValue(nameof(ZuteilungBei), ZuteilungBei);
            AbschlussGebuehr = ele.GetAttributeValue(nameof(AbschlussGebuehr), AbschlussGebuehr);
            GebundenerSollzins = ele.GetAttributeValue(nameof(GebundenerSollzins), GebundenerSollzins);
        }

    }
}
