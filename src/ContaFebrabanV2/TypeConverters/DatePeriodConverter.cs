using FlatFile.Core;
using ContaFebrabanV2.CustomTypes;
using System;

namespace ContaFebrabanV2.TypeConverters
{
    public class DatePeriodConverter : ITypeConverter
    {
        private DateConverter dateConverter;

        public DatePeriodConverter()
        {
            this.dateConverter = new DateConverter();
        }
        public bool CanConvertFrom(Type type)
        {
            return type == typeof(string);
        }

        public bool CanConvertTo(Type type)
        {
            return type == typeof(DateTimePeriod);
        }

        public object ConvertFromString(string source)
        {
            if (source.Length != 16)
                return false;

            var inicio = (DateTime)dateConverter.ConvertFromString(source.Substring(0, 8));
            var fim = (DateTime)dateConverter.ConvertFromString(source.Substring(8, 8));
            return new DateTimePeriod(inicio, fim);
        }

        public string ConvertToString(object source)
        {
            var periodo = source as DateTimePeriod;
            return dateConverter.ConvertToString(periodo.Inicio) + dateConverter.ConvertToString(periodo.Fim);
        }
    }
}