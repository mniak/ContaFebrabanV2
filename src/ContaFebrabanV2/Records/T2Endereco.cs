namespace ContaFebrabanV2.Records
{
    public class T2Endereco : BaseRecord
    {
        public string CodigoNrc { get; set; }
        public string DDD { get; set; }
        public string Telefone { get; set; }
        public string CaracteristicaRecurso { get; set; }

        public string A_CodigoCnl { get; set; }
        public string A_NomeLocalidade { get; set; }
        public string A_Uf { get; set; }
        public string A_Endereco { get; set; }
        public string A_EnderecoNro { get; set; }
        public string A_EnderecoComplemento { get; set; }
        public string A_EnderecoBairro { get; set; }

        public string B_CodigoCnl { get; set; }
        public string B_NomeLocalidade { get; set; }
        public string B_Uf { get; set; }
        public string B_Endereco { get; set; }
        public string B_EnderecoNro { get; set; }
        public string B_EnderecoComplemento { get; set; }
        public string B_EnderecoBairro { get; set; }

        public string Filler { get; set; }
    }
}
