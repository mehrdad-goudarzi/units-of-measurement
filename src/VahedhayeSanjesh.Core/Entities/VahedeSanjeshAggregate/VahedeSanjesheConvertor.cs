using VahedhayeSanjesh.Core.Exceptions;

namespace VahedhayeSanjesh.Core.Entities.VahedeSanjeshAggregate
{
    public static class VahedeSanjesheConvertor
    {
        public static double Convert(double value, VahedeSanjesheFormoldar from, VahedeSanjesheFormoldar to)
        {
            ValidateBodeAndazeGiri(from, to);

            double valueDarVahedePaye = from.ConvertToPaye(value);
            double valueDarVahedeFormoldar = to.ConvertFromPaye(valueDarVahedePaye);

            return valueDarVahedeFormoldar;
        }

        public static double Convert(double value, VahedeSanjesheZaribdar from, VahedeSanjesheZaribdar to)
        {
            ValidateBodeAndazeGiri(from, to);

            double valueDarVahedePaye = from.ConvertToPaye(value);
            double valueDarVahedeFormoldar = to.ConvertFromPaye(valueDarVahedePaye);

            return valueDarVahedeFormoldar;
        }

        public static void ValidateBodeAndazeGiri(VahedeSanjesh vahede1, VahedeSanjesh vahede2)
        {
            if (!vahede1.Bod.Equals(vahede2.Bod))
                throw new InvalidVahedeSanjeshConvertException();
        }
    }
}