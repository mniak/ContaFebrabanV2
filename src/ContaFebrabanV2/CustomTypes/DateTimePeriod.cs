using System;

namespace ContaFebrabanV2.CustomTypes
{
    public class DateTimePeriod
    {
        public DateTimePeriod()
        {

        }
        public DateTimePeriod(DateTime inicio, DateTime fim)
        {
            Inicio = inicio;
            Fim = fim;
        }

        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
    }
}
