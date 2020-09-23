using NUnit.Framework;
using VahedhayeSanjesh.Core.Entities.VahedeSanjeshAggregate;
using VahedhayeSanjesh.Core.Exceptions;

namespace VahedhayeSanjesh.Core.UnitTests
{
    public class FormolProccessorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Proccess_aPlus2_4()
        {
            string exp = "a+2";
            var formol = new FormoleTabdil(exp);
            var result = FormolProccessor.Proccess(formol, 2);

            Assert.AreEqual(4, result);
        }

        [Test]
        public void Proccess_aMultiple2_8()
        {
            string exp = "a*2";
            var formol = new FormoleTabdil(exp);
            var result = FormolProccessor.Proccess(formol, 4);

            Assert.AreEqual(8, result);
        }

        [Test]
        public void Proccess_aDivision2_4()
        {
            string exp = "a/2";
            var formol = new FormoleTabdil(exp);
            var result = FormolProccessor.Proccess(formol, 8);

            Assert.AreEqual(4, result);
        }

        [Test]
        public void Proccess_Braces_12()
        {
            string exp = "(a+2)*3";
            var formol = new FormoleTabdil(exp);
            var result = FormolProccessor.Proccess(formol, 2);

            Assert.AreEqual(12, result);
        }

        [Test]
        public void Proccess_Braces_8()
        {
            string exp = "a+(2*3)";
            var formol = new FormoleTabdil(exp);
            var result = FormolProccessor.Proccess(formol, 2);

            Assert.AreEqual(8, result);
        }
    }
}