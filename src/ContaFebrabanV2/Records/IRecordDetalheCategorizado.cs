namespace ContaFebrabanV2.Records
{
    public interface IRecordDetalheCategorizado : IRecordDetalhe
    {
        string CodCategoria { get; set; }
        string Categoria { get; set; }
    }
}
