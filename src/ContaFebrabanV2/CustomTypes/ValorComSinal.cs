using System;

namespace ContaFebrabanV2.CustomTypes
{
    public class ValorComSinal
    {
        public ValorComSinal()
        {

        }
        public ValorComSinal(decimal valor) : this(SinalEnum.Positivo, valor)
        {

        }
        public ValorComSinal(SinalEnum sinal, decimal valor)
        {
            Sinal = sinal.IsPositivo && valor >= 0 || sinal.IsNegativo && valor < 0 ? SinalEnum.Positivo : SinalEnum.Negativo;
            Valor = Math.Abs(valor);
        }

        public SinalEnum Sinal { get; set; }
        public decimal Valor { get; set; }

        public static implicit operator decimal(ValorComSinal value)
        {
            if (value == null)
                throw new ArgumentException("Invalid object", nameof(value));
            var result = value.Sinal.IsPositivo ? value.Valor : -value.Valor;
            return result;
        }
        public static implicit operator ValorComSinal(decimal value)
        {
            return new ValorComSinal(value);
        }
        public override string ToString()
        {
            return (Valor * (Sinal.IsNegativo ? -1 : 1)).ToString();
        }
    }
}
