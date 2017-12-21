using System;

namespace ContaFebrabanV2.CustomTypes
{
    public class SinalEnum : IEquatable<SinalEnum>
    {
        private char sinal;

        private SinalEnum(char sinal)
        {
            this.sinal = sinal;
        }
        public bool IsPositivo => sinal == '+';
        public bool IsNegativo => sinal == '-';

        public readonly static SinalEnum Positivo = new SinalEnum('+');
        public readonly static SinalEnum Negativo = new SinalEnum('-');

        public static SinalEnum Parse(char sinal)
        {
            if (sinal == '+')
                return SinalEnum.Positivo;
            return SinalEnum.Negativo;
        }

        public bool Equals(SinalEnum other)
        {
            if (other == null)
                return false;
            return this.IsPositivo == other.IsPositivo;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as SinalEnum);
        }

        public override int GetHashCode()
        {
            var hashCode = 1048085872;
            hashCode = hashCode * -1521134295 + sinal.GetHashCode();
            hashCode = hashCode * -1521134295 + IsPositivo.GetHashCode();
            hashCode = hashCode * -1521134295 + IsNegativo.GetHashCode();
            return hashCode;
        }
        public override string ToString()
        {
            return this.sinal.ToString();
        }
    }
}
