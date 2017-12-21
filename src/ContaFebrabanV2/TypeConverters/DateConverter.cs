using FlatFile.Core;
using System;
using System.Globalization;

namespace ContaFebrabanV2.TypeConverters
{
    internal class DateConverter : ITypeConverter
    {
        private const string FORMAT = "yyyyMMdd";
        public bool CanConvertFrom(Type type)
        {
            return type == typeof(string);
        }

        public bool CanConvertTo(Type type)
        {
            return type == typeof(DateTime);
        }

        public object ConvertFromString(string source)
        {
            if (!DateTime.TryParseExact(source, FORMAT, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
                return null;
            return result;
        }

        public string ConvertToString(object source)
        {
            var date = (DateTime)source;
            return date.ToString(FORMAT);
        }
    }
}
