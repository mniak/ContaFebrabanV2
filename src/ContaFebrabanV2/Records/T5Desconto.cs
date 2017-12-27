using ContaFebrabanV2.CustomTypes;
using System;

namespace ContaFebrabanV2.Records
{
    public class T5Desconto : BaseRecord, IRecordDetalhe, IRecordDetalheAgrupado
    {
        public DateTime DataVencimento { get; set; }
        public DateTime DataEmissao { get; set; }
        public string CodigoNrc { get; set; }
        public string IdConta { get; set; }
        public int CnlRecurso { get; set; }
        public string DDD { get; set; }
        public string Telefone { get; set; }
        public string CodGrupo { get; set; }
        public string Grupo { get; set; }
        public decimal BaseCalculoDesconto { get; set; }
        public decimal PercentualDesconto { get; set; }
        public DateTimePeriod PeriodoAcerto { get; set; }
        public int ClasseServico { get; set; }

        internal SinalEnum _sinalValorLigacao { get; set; } = SinalEnum.Positivo;
        internal decimal _valorAbsolutoLigacao { get; set; }
        public ValorComSinal ValorLigacao
        {
            get
            {
                return new ValorComSinal(_sinalValorLigacao, _valorAbsolutoLigacao);
            }
            set
            {
                this._sinalValorLigacao = value.Sinal;
                this._valorAbsolutoLigacao = value.Valor;
            }
        }
    }
}
