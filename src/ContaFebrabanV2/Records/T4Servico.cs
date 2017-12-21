using ContaFebrabanV2.CustomTypes;
using System;

namespace ContaFebrabanV2.Records
{
    public class T4Servico : BaseRecord
    {
        public DateTime DataVencimento { get; set; }
        public DateTime DataEmissao { get; set; }
        public string CodigoNrc { get; set; }
        public int CnlRecurso { get; set; }
        public string DDD { get; set; }
        public string Telefone { get; set; }
        public string CaracteristicaRecurso { get; set; }
        public DateTime? DataServico { get; set; }
        public int CnlLocalidadeChamada { get; set; }
        public string NomeLocalidadeChamada { get; set; }
        public string UfTelefoneChamado { get; set; }
        public string CodigoNacionalInter { get; set; }
        public string CodigoOperadora { get; set; }
        public string DescricaoOperadora { get; set; }
        public string CodigoPaisChamado { get; set; }
        public string CodigoDeArea { get; set; }
        public string NumeroTelefoneChamado { get; set; }
        public string ConjugadoTelefoneChamado { get; set; }
        public TimeSpan? DuracaoLigacao { get; set; }
        public TimeSpan? HorarioLigacao { get; set; }
        public string Grupo { get; set; }
        public string DescricaoGrupo { get; set; }
        public string Categoria { get; set; }
        public string DescricaoCategoria { get; set; }
        public ValorComSinal ValorLigacao { get; set; }
        public int ClasseServico { get; set; }
        public string Filler { get; set; }
    }
}
