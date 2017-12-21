using FlatFile.Core;
using ContaFebrabanV2.CustomTypes;
using System;
using System.Globalization;

namespace ContaFebrabanV2.TypeConverters
{
    public class ValorComSinalConverter : ITypeConverter
    {
        public bool CanConvertFrom(Type type)
        {
            return type == typeof(string);
        }

        public bool CanConvertTo(Type type)
        {
            return type == typeof(ValorComSinal);
        }

        public object ConvertFromString(string source)
        {
            if (source.Length != 14)
                return null;

            var sinal = SinalEnum.Parse(source[0]);
            var valor = decimal.Parse(source.Substring(1), CultureInfo.InvariantCulture);
            var result = new ValorComSinal(sinal, valor);
            return result;
        }

        public string ConvertToString(object source)
        {
            var valorComSinal = source as ValorComSinal;
            if (valorComSinal == null)
                return null;
            var result = valorComSinal.Sinal.ToString() + valorComSinal.Valor.ToString(new string('0', 13));
            return result;
        }
    }
}