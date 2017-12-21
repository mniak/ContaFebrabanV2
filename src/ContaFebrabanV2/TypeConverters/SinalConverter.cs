using FlatFile.Core;
using ContaFebrabanV2.CustomTypes;
using System;

namespace ContaFebrabanV2.TypeConverters
{
    public class SinalConverter : ITypeConverter
    {
        public bool CanConvertFrom(Type type)
        {
            return type == typeof(string);
        }

        public bool CanConvertTo(Type type)
        {
            return type == typeof(SinalEnum);
        }

        public object ConvertFromString(string source)
        {
            return source == "+" ? SinalEnum.Positivo : SinalEnum.Negativo;
        }

        public string ConvertToString(object source)
        {
            var sinal = source as SinalEnum;
            return sinal.ToString();
        }
    }
}
