using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinzanzierungsApp
{
    public interface IBaustein
    {
        event EventHandler SmthChanged;

        string Title { get; set; }

        IBaustein ParentBaustein { get; set; }

        double Auszahlung { get; }
        double Rate { get; }
        double GezahlteZinsen { get; }
        DateTime StartDatum { get; }
        DateTime EndDatum { get; }
        double RestSchuld { get; }
        double ZinsenProJahr { get; set; }
        bool Unsicher { get; }

        void ToXml(XElement xBaustein);
        void Calc();
    }
}
