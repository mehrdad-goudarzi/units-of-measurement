using NUnit.Framework;
using VahedhayeSanjesh.Core.Entities.VahedeSanjeshAggregate;
using VahedhayeSanjesh.Core.Exceptions;

namespace VahedhayeSanjesh.Core.UnitTests
{
    public class FormoleTabdilTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EmptyFormole_ThrowEmptyFormoleTabdilException()
        {
            Assert.Throws<EmptyFormoleTabdilException>(new TestDelegate(CreateEmptyFormoleTabdil));
        }

        [Test]
        public void WithoutVariableFormole_ThrowFormolMoteghayerNadaradException()
        {
            Assert.Throws<FormolMoteghayerNadaradException>(new TestDelegate(CreateFormoleTabdilWithoutVariable));
        }

        [Test]
        public void MoreThanOneVariableFormole_ThrowInvalidFormoleTabdilException()
        {
            Assert.Throws<InvalidFormoleTabdilException>(new TestDelegate(CreateFormoleTabdilWithMoreThanOneVariable));
        }

        [Test]
        public void SumTwoNumber_ValueSameAsInput()
        {
            string exp = "2+a";
            var formol = new FormoleTabdil(exp);

            Assert.AreEqual(exp, formol.Value);
        }

        private void CreateFormoleTabdilWithMoreThanOneVariable()
        {
            new FormoleTabdil("a+2+b");
        }

        private void CreateFormoleTabdilWithoutVariable()
        {
            new FormoleTabdil("2+2");
        }

        private void CreateEmptyFormoleTabdil()
        {
            new FormoleTabdil(string.Empty);
        }
    }
}