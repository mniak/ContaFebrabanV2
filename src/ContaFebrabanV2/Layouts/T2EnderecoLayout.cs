using ContaFebrabanV2.Records;

namespace ContaFebrabanV2.Layouts
{
    internal class T2EnderecoLayout : BaseLayout<T2Endereco>
    {
        public T2EnderecoLayout()
        {
            this.WithMember(x => x.CodigoNrc            , c => c.WithLength(25 ))
                .WithMember(x => x.DDD                  , c => c.WithLength(2  ))
                .WithMember(x => x.Telefone             , c => c.WithLength(10 ))
                .WithMember(x => x.CaracteristicaRecurso, c => c.WithLength(15 ))
                .WithMember(x => x.A_CodigoCnl          , c => c.WithLength(5  ))
                .WithMember(x => x.A_NomeLocalidade     , c => c.WithLength(20 ))
                .WithMember(x => x.A_Uf                 , c => c.WithLength(2  ))
                .WithMember(x => x.A_Endereco           , c => c.WithLength(30 ))
                .WithMember(x => x.A_EnderecoNro        , c => c.WithLength(5  ))
                .WithMember(x => x.A_EnderecoComplemento, c => c.WithLength(10 ))
                .WithMember(x => x.A_EnderecoBairro     , c => c.WithLength(20 ))
                .WithMember(x => x.B_CodigoCnl          , c => c.WithLength(5  ))
                .WithMember(x => x.B_NomeLocalidade     , c => c.WithLength(20 ))
                .WithMember(x => x.B_Uf                 , c => c.WithLength(2  ))
                .WithMember(x => x.B_Endereco           , c => c.WithLength(30 ))
                .WithMember(x => x.B_EnderecoNro        , c => c.WithLength(5  ))
                .WithMember(x => x.B_EnderecoComplemento, c => c.WithLength(10 ))
                .WithMember(x => x.B_EnderecoBairro     , c => c.WithLength(20 ))
                .WithMember(x => x.Filler               , c => c.WithLength(101))
                ;
        }
    }
}
