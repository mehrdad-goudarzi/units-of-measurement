using VahedhayeSanjesh.Core.Exceptions;

namespace VahedhayeSanjesh.Core.Entities.VahedeSanjeshAggregate
{
    public static class VahedeSanjesheConvertor
    {
        // تبدیل واحد سنجش فرمول دار به یکدیگر
        public static double Convert(double value, VahedeSanjesheFormoldar from, VahedeSanjesheFormoldar to)
        {
            ValidateBodeAndazeGiri(from, to);

            double valueDarVahedePaye = from.ConvertToPaye(value);
            double valueDarVahedeFormoldar = to.ConvertFromPaye(valueDarVahedePaye);

            return valueDarVahedeFormoldar;
        }

        // تبدیل واحد سنجش ضریبدار به یکدیگر
        public static double Convert(double value, VahedeSanjesheZaribdar from, VahedeSanjesheZaribdar to)
        {
            ValidateBodeAndazeGiri(from, to);

            double valueDarVahedePaye = from.ConvertToPaye(value);
            double valueDarVahedeFormoldar = to.ConvertFromPaye(valueDarVahedePaye);

            return valueDarVahedeFormoldar;
        }

        // بررسی یکی بودن بعد واحدهای سنجش که یکی باشد
        private static void ValidateBodeAndazeGiri(VahedeSanjesh vahede1, VahedeSanjesh vahede2)
        {
            if (!vahede1.Bod.Equals(vahede2.Bod))
                throw new InvalidVahedeSanjeshConvertException();
        }
    }
}