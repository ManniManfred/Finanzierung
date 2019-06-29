using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinzanzierungsApp
{
    public static class Extensions
    {
        public static string GetAttributeValue(this XElement ele, string name, string fallback)
        {
            var attr = ele.Attribute(name);
            if (attr == null)
                return fallback;

            return attr.Value;
        }

        public static double GetAttributeValue(this XElement ele, string name, double fallback)
        {
            var attr = ele.Attribute(name);
            if (attr == null)
                return fallback;

            if (!double.TryParse(attr.Value, NumberStyles.Any, CultureInfo.InvariantCulture, out double result))
                return fallback;

            return result;
        }

        public static int GetAttributeValue(this XElement ele, string name, int fallback)
        {
            var attr = ele.Attribute(name);
            if (attr == null)
                return fallback;

            if (!int.TryParse(attr.Value, out int result))
                return fallback;

            return result;
        }
    }
}
