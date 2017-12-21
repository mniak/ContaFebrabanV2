using FlatFile.Core;
using System;
using System.Globalization;

namespace ContaFebrabanV2.TypeConverters
{
    internal class DateTimeConverter : ITypeConverter
    {
        private const string FORMAT = "yyyyMMddHHmmss";
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
            var result = DateTime.ParseExact(source, FORMAT, CultureInfo.InvariantCulture);
            return result;
        }

        public string ConvertToString(object source)
        {
            var date = (DateTime)source;
            return date.ToString(FORMAT);
        }
    }
}
