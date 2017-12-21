using ContaFebrabanV2.CustomTypes;
using System;

namespace ContaFebrabanV2.Records
{
    public class T5Desconto : BaseRecord
    {
        public DateTime DataVencimento { get; set; }
        public DateTime DataEmissao { get; set; }
        public string CodigoNrc { get; set; }
        public string IdConta { get; set; }
        public int CnlRecurso { get; set; }
        public string DDD { get; set; }
        public string Telefone { get; set; }
        public string GrupoCategoria { get; set; }
        public string DescricaoGrupoCategoria { get; set; }
        public SinalEnum SinalValorLigacao { get; set; }
        public decimal BaseCalculoDesconto { get; set; }
        public decimal PercentualDesconto { get; set; }
        public decimal ValorLigacao { get; set; }
        public DateTimePeriod PeriodoAcerto { get; set; }
        public int ClasseServico { get; set; }
        public string Filler { get; set; }
    }
}
