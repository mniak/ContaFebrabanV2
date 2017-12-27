using ContaFebrabanV2.CustomTypes;
using System;

namespace ContaFebrabanV2.Records
{
    public class T9Trailer : BaseRecord
    {
        public string CodigoCliente { get; set; }
        public string IdConta { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataEmissão { get; set; }
        public int QuantidadeRegistros { get; set; }
        public int QuantidadeRecursos { get; set; }
        public ValorComSinal ValorTotal { get; set; }
    }
}
