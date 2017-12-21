using FlatFile.Core;
using System;

namespace ContaFebrabanV2.TypeConverters
{
    public class MinutesConverter : ITypeConverter
    {
        public bool CanConvertFrom(Type type)
        {
            return type == typeof(string);
        }

        public bool CanConvertTo(Type type)
        {
            return type == typeof(TimeSpan);
        }

        public object ConvertFromString(string source)
        {
            if (!double.TryParse(source, out double dmin))
                return null;
            var result = TimeSpan.FromMinutes(dmin);
            return result;
        }

        public string ConvertToString(object source)
        {
            var time = (TimeSpan)source;
            var result = time.TotalMinutes.ToString("0000.0");
            return result;
        }
    }
}
