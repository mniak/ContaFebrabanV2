using ContaFebrabanV2.CustomTypes;
using System;

namespace ContaFebrabanV2.Records
{
    public interface IRecordDetalhe
    {
        DateTime DataVencimento { get; set; }
        DateTime DataEmissao { get; set; }
        string CodigoNrc { get; set; }
        int CnlRecurso { get; set; }
        string DDD { get; set; }
        string Telefone { get; set; }
        ValorComSinal ValorLigacao { get; set; }
        int ClasseServico { get; set; }
    }
}
