using ContaFebrabanV2.Records;
using ContaFebrabanV2.TypeConverters;

namespace ContaFebrabanV2.Layouts
{
    internal class T4ServicoLayout : BaseLayout<T4Servico>
    {
        public T4ServicoLayout()
        {
            this
                .WithMember(x => x.DataVencimento          , c => c.WithLength(8 ).WithTypeConverter<DateConverter>())
                .WithMember(x => x.DataEmissao             , c => c.WithLength(8 ).WithTypeConverter<DateConverter>())
                .WithMember(x => x.CodigoNrc               , c => c.WithLength(25).WithRightPadding(' '))
                .WithMember(x => x.CnlRecurso              , c => c.WithLength(5 ))
                .WithMember(x => x.DDD                     , c => c.WithLength(2 ).WithRightPadding(' '))
                .WithMember(x => x.Telefone                , c => c.WithLength(10).WithRightPadding(' '))
                .WithMember(x => x.CaracteristicaRecurso   , c => c.WithLength(15).WithRightPadding(' '))
                .WithMember(x => x.DataServico             , c => c.WithLength(8 ).WithTypeConverter<DateConverter>())
                .WithMember(x => x.CnlLocalidadeChamada    , c => c.WithLength(5 ).WithRightPadding(' '))
                .WithMember(x => x.NomeLocalidadeChamada   , c => c.WithLength(25).WithRightPadding(' '))
                .WithMember(x => x.UfTelefoneChamado       , c => c.WithLength(2 ).WithRightPadding(' '))
                .WithMember(x => x.CodigoNacionalInter     , c => c.WithLength(2 ).WithRightPadding(' '))
                .WithMember(x => x.CodigoOperadora         , c => c.WithLength(2 ).WithRightPadding(' '))
                .WithMember(x => x.DescricaoOperadora      , c => c.WithLength(20).WithRightPadding(' '))
                .WithMember(x => x.CodigoPaisChamado       , c => c.WithLength(3 ).WithRightPadding(' '))
                .WithMember(x => x.CodigoDeArea            , c => c.WithLength(4 ).WithRightPadding(' '))
                .WithMember(x => x.TelefoneChamado         , c => c.WithLength(10).WithRightPadding(' '))
                .WithMember(x => x.ConjugadoTelefoneChamado, c => c.WithLength(2 ).WithRightPadding(' ')) 
                .WithMember(x => x.DuracaoLigacao          , c => c.WithLength(6 ).WithTypeConverter<MinutesConverter>())
                .WithMember(x => x.HorarioLigacao          , c => c.WithLength(6 ).WithTypeConverter<TimeConverter>())
                .WithMember(x => x.CodGrupo                , c => c.WithLength(3 ).WithRightPadding(' '))
                .WithMember(x => x.Grupo                   , c => c.WithLength(30).WithRightPadding(' '))
                .WithMember(x => x.CodCategoria               , c => c.WithLength(3 ).WithRightPadding(' '))
                .WithMember(x => x.Categoria      , c => c.WithLength(40).WithRightPadding(' '))
                .WithMember(x => x.ValorLigacao            , c => c.WithLength(14).WithTypeConverter<ValorComSinalConverter>())
                .WithMember(x => x.ClasseServico           , c => c.WithLength(5 ))
                .WithMember(x => x.Filler                  , c => c.WithLength(74).WithRightPadding(' '))
                ;
        }
    }
}
