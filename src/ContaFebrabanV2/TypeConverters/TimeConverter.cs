using FlatFile.Core;
using System;
using System.Globalization;

namespace ContaFebrabanV2.TypeConverters
{
    public class TimeConverter : ITypeConverter
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
            if (!TimeSpan.TryParseExact(source, "hhmmss", CultureInfo.InvariantCulture, TimeSpanStyles.None, out TimeSpan result))
                return null;
            return result;
        }

        public string ConvertToString(object source)
        {
            var time = (TimeSpan)source;
            return time.ToString("hhmmss");
        }
    }
}
