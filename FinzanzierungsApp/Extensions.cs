using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinzanzierungsApp
{
    public static class Extensions
    {
        public static int MonthDifference(this DateTime lValue, DateTime rValue)
        {
            return Math.Abs((lValue.Month - rValue.Month) + 12 * (lValue.Year - rValue.Year));
        }

        public static T GetAttributeValue<T>(this XElement ele, string name, T fallback)
            where T : System.Enum
        {
            var attr = ele.Attribute(name);
            if (attr == null)
                return fallback;

            return (T)Enum.Parse(typeof(T), attr.Value);
        }

        public static string GetAttributeValue(this XElement ele, string name, string fallback)
        {
            var attr = ele.Attribute(name);
            if (attr == null)
                return fallback;

            return attr.Value;
        }

        public static Color GetAttributeValue(this XElement ele, string name, Color fallback)
        {
            var attr = ele.Attribute(name);
            if (attr == null)
                return fallback;

            return Color.FromArgb(int.Parse(attr.Value));
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


        public static bool GetAttributeValue(this XElement ele, string name, bool fallback)
        {
            var attr = ele.Attribute(name);
            if (attr == null)
                return fallback;

            if (!bool.TryParse(attr.Value, out var result))
                return fallback;

            return result;
        }

        public static DateTime GetAttributeValue(this XElement ele, string name, DateTime fallback)
        {
            var attr = ele.Attribute(name);
            if (attr == null)
                return fallback;

            if (!DateTime.TryParse(attr.Value, out var result))
                return fallback;

            return result;
        }
    }
}
