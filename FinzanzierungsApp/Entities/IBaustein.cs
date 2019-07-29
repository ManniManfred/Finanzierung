﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinzanzierungsApp
{
    public interface IBaustein
    {
        string Title { get; set; }

        IBaustein ParentBaustein { get; set; }

        double Auszahlung { get; }
        double Rate { get; }
        double GezahlteZinsen { get; }
        DateTime StartDatum { get; }
        DateTime EndDatum { get; }

        void ToXml(XElement xBaustein);
        void Calc();
    }
}
