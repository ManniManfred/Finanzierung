using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinzanzierungsApp
{
    public class AnnuDarlehen : AbstractBaustein
    {
        public override void Calc()
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

            if (startSchuld != 0.0 && zinsenProJahr != 0.0 && rate != 0.0)
            {
                while (restSchuld > 0.0
                    && !double.IsInfinity(restSchuld)
                    && (laufzeitInMonate == 0 || monat < laufzeitInMonate))
                {
                    foreach (var ti in GetSonderTilgungen(StartDatum.AddMonths(monat)))
                    {
                        restSchuld -= ti.Betrag;
                    }

                    gezahlteZinsen += restSchuld * zinsenProMonat;

                    if (monat >= keineTilgungMonate)
                    {

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

            FireSmthChanged();
        }


        public override void ToXml(XElement ele)
        {
            base.ToXml(ele);
        }

        public override void FromXml(Variante finazierung, XElement ele)
        {
            base.FromXml(finazierung, ele);
        }

    }
}
