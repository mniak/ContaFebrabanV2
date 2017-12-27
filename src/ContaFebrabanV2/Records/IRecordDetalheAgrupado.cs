namespace ContaFebrabanV2.Records
{
    public interface IRecordDetalheAgrupado : IRecordDetalhe
    {
        string CodGrupo { get; set; }
        string Grupo { get; set; }
    }
}
