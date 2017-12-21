using ContaFebrabanV2.Records;
using ContaFebrabanV2.TypeConverters;

namespace ContaFebrabanV2.Layouts
{
    internal class T1ResumoLayout : BaseLayout<T1Resumo>
    {
        public T1ResumoLayout()
        {
            this.WithMember(x => x.IdConta                  , c => c.WithLength(25))
                .WithMember(x => x.DataVencimento           , c => c.WithLength(8 ).WithTypeConverter<DateConverter>())
                .WithMember(x => x.DataEmissao              , c => c.WithLength(8 ).WithTypeConverter<DateConverter>())
                .WithMember(x => x.CodigoNrc                , c => c.WithLength(25).WithLeftPadding(' '))
                .WithMember(x => x.CodigoCnl                , c => c.WithLength(5 ))
                .WithMember(x => x.Localidade               , c => c.WithLength(25).WithLeftPadding(' '))
                .WithMember(x => x.DDD                      , c => c.WithLength(2 ).WithLeftPadding(' '))
                .WithMember(x => x.Telefone                 , c => c.WithLength(10))
                .WithMember(x => x.CodigoTipoServico        , c => c.WithLength(4 ).WithLeftPadding(' '))
                .WithMember(x => x.DescricaoTipoServico     , c => c.WithLength(35).WithLeftPadding(' '))
                .WithMember(x => x.CaracteristicaRecurso    , c => c.WithLength(15).WithLeftPadding(' '))
                .WithMember(x => x.DegrauRecurso            , c => c.WithLength(2 ).WithLeftPadding(' '))
                .WithMember(x => x.VelocidadeRecurso        , c => c.WithLength(5 ).WithLeftPadding(' '))
                .WithMember(x => x.UnidadeVelocidadeRecurso , c => c.WithLength(4 ).WithLeftPadding(' '))
                .WithMember(x => x.PeriodoAssinatura        , c => c.WithLength(16).WithTypeConverter<DatePeriodConverter>())
                .WithMember(x => x.PeriodoMedido            , c => c.WithLength(16).WithTypeConverter<DatePeriodConverter>())
                .WithMember(x => x.UnidadeConsumo           , c => c.WithLength(5 ).WithLeftPadding(' '))
                .WithMember(x => x.QuantidadeConsumo        , c => c.WithLength(7 ))
                .WithMember(x => x.ValorConsumo             , c => c.WithLength(14).WithTypeConverter<ValorComSinalConverter>())
                .WithMember(x => x.ValorAssinatura          , c => c.WithLength(14).WithTypeConverter<ValorComSinalConverter>())
                .WithMember(x => x.Aliquota                 , c => c.WithLength(2 ))
                .WithMember(x => x.ValorIcms                , c => c.WithLength(14).WithTypeConverter<ValorComSinalConverter>())
                .WithMember(x => x.ValorOutrosImpostos      , c => c.WithLength(14).WithTypeConverter<ValorComSinalConverter>())
                .WithMember(x => x.NroNotaFiscal            , c => c.WithLength(12).WithLeftPadding(' '))
                .WithMember(x => x.ValorConta               , c => c.WithLength(14).WithTypeConverter<ValorComSinalConverter>())
                .WithMember(x => x.Filler                   , c => c.WithLength(36).WithLeftPadding(' '))
                ;
        }
    }
}
