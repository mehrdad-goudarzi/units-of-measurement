using NUnit.Framework;
using VahedhayeSanjesh.Core.Entities.VahedeSanjeshAggregate;
using VahedhayeSanjesh.Core.Exceptions;

namespace VahedhayeSanjesh.Core.UnitTests
{
    public class VahedeSanjesheFormoldarConvertorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void VahedeSanjesheFormoldar_KelvinToFahrenheit_32_27315()
        {
            BodeAndazeGiri bod = new BodeAndazeGiri("بعد1", "b1");

            FormoleTabdil formoleTabdilKelvinBPaye = new FormoleTabdil("a-273.15");
            FormoleTabdil formoleTabdilKelvinAzPaye = new FormoleTabdil("a+273.15");
            VahedeSanjesheFormoldar VahedeSanjesheKelvin = new VahedeSanjesheFormoldar("کلوین", "Kelvin", "K", bod, formoleTabdilKelvinAzPaye, formoleTabdilKelvinBPaye);

            FormoleTabdil formoleTabdilFahrenheitBPaye = new FormoleTabdil("(a-32)*5/9");
            FormoleTabdil formoleTabdilFahrenheitAzPaye = new FormoleTabdil("(a*9/5)+32");
            VahedeSanjesheFormoldar VahedeSanjesheFahrenheit = new VahedeSanjesheFormoldar("فارنهایت", "Fahrenheit", "K", bod, formoleTabdilFahrenheitAzPaye, formoleTabdilFahrenheitBPaye);

            double resultInKelvin = VahedeSanjesheConvertor.Convert(32, VahedeSanjesheFahrenheit, VahedeSanjesheKelvin);
            Assert.AreEqual(273.15, resultInKelvin);
        }

        [Test]
        public void VahedeSanjesheZaribdar_MillimeterToCentimeter_1000_100()
        {
            BodeAndazeGiri bod = new BodeAndazeGiri("طول", "Length");

            VahedeSanjesheZaribdar VahedeSanjesheMillimeter = new VahedeSanjesheZaribdar("میلیمتر", "Millimeter", "mm", bod, 0.001);
            VahedeSanjesheZaribdar VahedeSanjesheCentimeter = new VahedeSanjesheZaribdar("سانتی متر", "Centimeter", "cm", bod, 0.01);

            double result = VahedeSanjesheConvertor.Convert(1000, VahedeSanjesheMillimeter, VahedeSanjesheCentimeter);
            Assert.AreEqual(100, result);
        }
    }
}