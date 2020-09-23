using NUnit.Framework;
using VahedhayeSanjesh.Core.Entities.VahedeSanjeshAggregate;
using VahedhayeSanjesh.Core.Exceptions;

namespace VahedhayeSanjesh.Core.UnitTests
{
    public class BodeAndazeGiriTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EmptyValueEnglish_ThrowInvalidBodeAndazeGiriException()
        {
            Assert.Throws<InvalidBodeAndazeGiriException>(new TestDelegate(CreateBodeAndazeGiriWithEmptyEnglishName));
        }

        [Test]
        public void EmptyValueFarsi_ThrowInvalidBodeAndazeGiriException()
        {
            Assert.Throws<InvalidBodeAndazeGiriException>(new TestDelegate(CreateBodeAndazeGiriWithEmptyEnglishName));
        }

        private void CreateBodeAndazeGiriWithEmptyFarsiName()
        {
            new BodeAndazeGiri(string.Empty, "Length");
        }

        private void CreateBodeAndazeGiriWithEmptyEnglishName()
        {
            new BodeAndazeGiri("طول", string.Empty);
        }
    }
}