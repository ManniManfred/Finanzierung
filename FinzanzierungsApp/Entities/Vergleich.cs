using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Be.Timvw.Framework.ComponentModel;

namespace FinzanzierungsApp
{
    public class Vergleich
    {
        public Vergleich()
        {
        }

        public SortableBindingList<Variante> Variants { get; } = new SortableBindingList<Variante>();

        internal void ToXml(XElement ele)
        {
            foreach (var variante in Variants)
            {
                var xVariante = new XElement("Variante");
                ele.Add(xVariante);
                variante.ToXml(xVariante);
            }
        }

        internal void FromXml(XElement ele)
        {
            Variants.Clear();

            foreach (var xVariante in ele.Elements("Variante"))
            {
                var variante = new Variante();
                variante.FromXml(xVariante);

                Variants.Add(variante);
            }
        }
    }
}
