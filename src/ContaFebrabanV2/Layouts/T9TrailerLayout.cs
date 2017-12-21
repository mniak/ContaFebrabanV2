using ContaFebrabanV2.Records;
using ContaFebrabanV2.TypeConverters;

namespace ContaFebrabanV2.Layouts
{
    internal class T9TrailerLayout : BaseLayout<T9Trailer>
    {
        public T9TrailerLayout()
        {
            this.WithMember(x => x.CodigoCliente      , c => c.WithLength(15 ))
                .WithMember(x => x.IdConta            , c => c.WithLength(25 ))
                .WithMember(x => x.DataVencimento     , c => c.WithLength(8  ).WithTypeConverter<DateConverter>())
                .WithMember(x => x.DataEmissão        , c => c.WithLength(8  ).WithTypeConverter<DateConverter>())
                .WithMember(x => x.QuantidadeRegistros, c => c.WithLength(12 ))
                .WithMember(x => x.QuantidadeRecursos , c => c.WithLength(12 ))
                .WithMember(x => x.ValorTotal         , c => c.WithLength(14 ).WithTypeConverter<ValorComSinalConverter>())
                .WithMember(x => x.Filler             , c => c.WithLength(243))
                ;

        }
    }
}
