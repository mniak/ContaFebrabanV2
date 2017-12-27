using ContaFebrabanV2.Records;
using ContaFebrabanV2.TypeConverters;

namespace ContaFebrabanV2.Layouts
{
    internal class T3BilheteLayout : BaseLayout<T3Bilhete>
    {
        public T3BilheteLayout()
        {
            this.WithMember(x => x.DataVencimento           , c=>c.WithLength(8 ).WithTypeConverter<DateConverter>())
                .WithMember(x => x.DataEmissao              , c=>c.WithLength(8 ).WithTypeConverter<DateConverter>())
                .WithMember(x => x.CodigoNrc                , c=>c.WithLength(25))
                .WithMember(x => x.CnlRecurso               , c=>c.WithLength(5 ))
                .WithMember(x => x.DDD                      , c=>c.WithLength(2 ))
                .WithMember(x => x.Telefone                 , c=>c.WithLength(10))
                .WithMember(x => x.CaracteristicaRecurso    , c=>c.WithLength(15))
                .WithMember(x => x.DegrauRecurso            , c=>c.WithLength(2 ))
                .WithMember(x => x.DataLigacao              , c=>c.WithLength(8 ).WithTypeConverter<DateConverter>())
                .WithMember(x => x.CnlChamada               , c=>c.WithLength(5 ))
                .WithMember(x => x.NomeLocalidadeChamada    , c=>c.WithLength(25))
                .WithMember(x => x.UfTelefoneChamado        , c=>c.WithLength(2 ))
                .WithMember(x => x.CodigoNacionalInter      , c=>c.WithLength(2 ))
                .WithMember(x => x.CodigoOperadora          , c=>c.WithLength(2 ))
                .WithMember(x => x.DescricaoOperadora       , c=>c.WithLength(20))
                .WithMember(x => x.CodigoPaisChamado        , c=>c.WithLength(3 ))
                .WithMember(x => x.CodigoDeArea             , c=>c.WithLength(4 ))
                .WithMember(x => x.TelefoneChamado          , c=>c.WithLength(10))
                .WithMember(x => x.ConjugadoChamado         , c=>c.WithLength(2 ))
                .WithMember(x => x.Duracao                  , c=>c.WithLength(6 ).WithTypeConverter<MinutesConverter>())
                .WithMember(x => x.CodCategoria             , c=>c.WithLength(3 ))
                .WithMember(x => x.Categoria                , c=>c.WithLength(50))
                .WithMember(x => x.HorarioLigacao           , c=>c.WithLength(6 ).WithTypeConverter<TimeConverter>())
                .WithMember(x => x.TipoChamada              , c=>c.WithLength(1 ))
                .WithMember(x => x.GrupoHorarioTarifario    , c=>c.WithLength(1 ))
                .WithMember(x => x.DescricaoHorarioTarifario, c=>c.WithLength(25))
                .WithMember(x => x.DegrauLigacao            , c=>c.WithLength(2 ))
                .WithMember(x => x._sinalValorLigacao       , c=>c.WithLength(1 ).WithTypeConverter<SinalConverter>())
                .WithMember(x => x.AliquotaIcms             , c=>c.WithLength(5 ))
                .WithMember(x => x._valorAbsolutoLigacao    , c=>c.WithLength(13))
                .WithMember(x => x.ClasseServico            , c=>c.WithLength(5 ))
                .WithMember(x => x.Filler                   , c=>c.WithLength(61))
                ;
        }
    }
}
