using ContaFebrabanV2.Records;
using ContaFebrabanV2.TypeConverters;

namespace ContaFebrabanV2.Layouts
{
    internal class T0HeaderLayout : BaseLayout<T0Header>
    {
        public T0HeaderLayout()
        {
            this.WithMember(x => x.DataGeracao           , c => c.WithLength(8  ).WithTypeConverter<DateConverter>())
                .WithMember(x => x.IdentificacaoOperadora, c => c.WithLength(15 ))
                .WithMember(x => x.EstadoOperadora       , c => c.WithLength(2  ))
                .WithMember(x => x.CodigoCliente         , c => c.WithLength(15 ))
                .WithMember(x => x.NomeCliente           , c => c.WithLength(40 ))
                .WithMember(x => x.CnpjCliente           , c => c.WithLength(15 ))
                .WithMember(x => x.IdConta               , c => c.WithLength(25 ))
                .WithMember(x => x.DataVencimento        , c => c.WithLength(8  ).WithTypeConverter<DateConverter>())
                .WithMember(x => x.DataEmissao           , c => c.WithLength(8  ).WithTypeConverter<DateConverter>())
                .WithMember(x => x.Filler                , c => c.WithLength(201))
                ;
        }
    }
}