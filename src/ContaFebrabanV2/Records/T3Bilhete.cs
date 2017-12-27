using ContaFebrabanV2.CustomTypes;
using System;

namespace ContaFebrabanV2.Records
{
    public class T3Bilhete : BaseRecord, IRecordDetalheCategorizado
    {
        public DateTime DataVencimento { get; set; }
        public DateTime DataEmissao { get; set; }
        public string CodigoNrc { get; set; }
        public int CnlRecurso { get; set; }
        public string DDD { get; set; }
        public string Telefone { get; set; }
        public string CaracteristicaRecurso { get; set; }
        public string DegrauRecurso { get; set; }
        public DateTime DataLigacao { get; set; }
        public int CnlChamada { get; set; }
        public string NomeLocalidadeChamada { get; set; }
        public string UfTelefoneChamado { get; set; }
        public string CodigoNacionalInter { get; set; }
        public string CodigoOperadora { get; set; }
        public string DescricaoOperadora { get; set; }
        public string CodigoPaisChamado { get; set; }
        public string CodigoDeArea { get; set; }
        public string TelefoneChamado { get; set; }
        public string ConjugadoChamado { get; set; }
        public TimeSpan Duracao { get; set; }
        public string CodCategoria { get; set; }
        public string Categoria { get; set; }
        public TimeSpan HorarioLigacao { get; set; }
        public char TipoChamada { get; set; }
        public char GrupoHorarioTarifario { get; set; }
        public string DescricaoHorarioTarifario { get; set; }
        public string DegrauLigacao { get; set; }
        public decimal AliquotaIcms { get; set; }
        public int ClasseServico { get; set; }

        internal SinalEnum _sinalValorLigacao { get; set; }
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
