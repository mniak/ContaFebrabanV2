using System;

namespace ContaFebrabanV2.Records
{
    public class T0Header : BaseRecord
    {
        public DateTime DataGeracao { get; internal set; }
        public string IdentificacaoOperadora { get; internal set; }
        public string EstadoOperadora { get; internal set; }
        public string CodigoCliente { get; internal set; }
        public string NomeCliente { get; internal set; }
        public string CnpjCliente { get; internal set; }
        public string IdConta { get; internal set; }
        public DateTime DataVencimento { get; internal set; }
        public DateTime DataEmissao { get; set; }
        public string Filler { get; set; }
    }
}
