using ContaFebrabanV2.Records;
using ContaFebrabanV2.TypeConverters;

namespace ContaFebrabanV2.Layouts
{
    internal class T5DescontoLayout : BaseLayout<T5Desconto>
    {
        public T5DescontoLayout()
        {
            this.WithMember(x => x.DataVencimento         , c => c.WithLength(8  ).WithTypeConverter<DateConverter>())
                .WithMember(x => x.DataEmissao            , c => c.WithLength(8  ).WithTypeConverter<DateConverter>())
                .WithMember(x => x.CodigoNrc              , c => c.WithLength(25 ))
                .WithMember(x => x.IdConta                , c => c.WithLength(25 ))
                .WithMember(x => x.CnlRecurso             , c => c.WithLength(5  ))
                .WithMember(x => x.DDD                    , c => c.WithLength(2  ))
                .WithMember(x => x.Telefone               , c => c.WithLength(10 ))
                .WithMember(x => x.CodGrupo               , c => c.WithLength(3  ))
                .WithMember(x => x.Grupo                  , c => c.WithLength(80 ))
                .WithMember(x => x._sinalValorLigacao     , c => c.WithLength(1  ).WithTypeConverter<SinalConverter>())
                .WithMember(x => x.BaseCalculoDesconto    , c => c.WithLength(13 ))
                .WithMember(x => x.PercentualDesconto     , c => c.WithLength(5  ))
                .WithMember(x => x._valorAbsolutoLigacao  , c => c.WithLength(13 ))
                .WithMember(x => x.PeriodoAcerto          , c => c.WithLength(28 ))
                .WithMember(x => x.ClasseServico          , c => c.WithLength(5  ))
                .WithMember(x => x.Filler                 , c => c.WithLength(106))
                ;
        }
    }
}
