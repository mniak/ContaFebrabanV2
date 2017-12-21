using FlatFile.FixedLength.Implementation;
using ContaFebrabanV2.Records;

namespace ContaFebrabanV2.Layouts
{
    internal class BaseLayout<T> : FixedLayout<T>
        where T : BaseRecord
    {
        public BaseLayout()
        {
            this.WithMember(x => x.CodigoTipoRegistro, c => c.WithLength(1 ))
                .WithMember(x => x.NroLinha          , c => c.WithLength(12))
                ;
        }
    }
}
