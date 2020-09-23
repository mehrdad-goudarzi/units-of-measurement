using VahedhayeSanjesh.Core.Entities.VahedeSanjeshAggregate;

namespace VahedhayeSanjesh.Core.Entities.VahedeSanjeshAggregate
{
    public static class VahedeSanjeshExtensions
    {
        public static double ConvertToPaye(this VahedeSanjesheFormoldar vahedeSanjeshe, double value)
        {
            return FormolProccessor.Proccess(vahedeSanjeshe.FormoleTabdilBeVahedePaye, value);
        }

        public static double ConvertFromPaye(this VahedeSanjesheFormoldar vahedeSanjeshe, double value)
        {
            return FormolProccessor.Proccess(vahedeSanjeshe.FormoleTabdilAzVahedePaye, value);
        }

        public static double ConvertToPaye(this VahedeSanjesheZaribdar vahedeSanjeshe, double value)
        {
            return value * vahedeSanjeshe.NesbatBeVahedePaye;
        }

        public static double ConvertFromPaye(this VahedeSanjesheZaribdar vahedeSanjeshe, double value)
        {
            return value / vahedeSanjeshe.NesbatBeVahedePaye;
        }
    }
}