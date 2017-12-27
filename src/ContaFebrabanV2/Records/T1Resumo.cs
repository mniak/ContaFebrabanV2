using ContaFebrabanV2.CustomTypes;
using System;

namespace ContaFebrabanV2.Records
{
    public class T1Resumo : BaseRecord
    {
        public T1Resumo()
        {

        }
        public string IdConta { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataEmissao { get; set; }
        public string CodigoNrc { get; set; }
        public int CodigoCnl { get; set; }
        public string Localidade { get; set; }
        public string DDD { get; set; }
        public string Telefone { get; set; }
        public string CodigoTipoServico { get; set; }
        public string DescricaoTipoServico { get; set; }

        public string CaracteristicaRecurso { get; set; }
        public string DegrauRecurso { get; set; }
        public string VelocidadeRecurso { get; set; }
        public string UnidadeVelocidadeRecurso { get; set; }
        public DateTimePeriod PeriodoAssinatura { get; set; }
        public DateTimePeriod PeriodoMedido { get; set; }
        public string UnidadeConsumo { get; set; }
        public int QuantidadeConsumo { get; set; }
        public ValorComSinal ValorConsumo { get; set; }

        public ValorComSinal ValorAssinatura { get; set; }
        public int Aliquota { get; set; }
        public ValorComSinal ValorIcms { get; set; }
        public ValorComSinal ValorOutrosImpostos { get; set; }
        public string NroNotaFiscal { get; set; }
        public ValorComSinal ValorConta { get; set; }
    }
}
