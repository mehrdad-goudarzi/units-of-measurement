using System.Collections.Generic;
using VahedhayeSanjesh.Core.Exceptions;

namespace VahedhayeSanjesh.Core.Entities.VahedeSanjeshAggregate
{
    // بعد اندازه گیری
    public class BodeAndazeGiri : ValueObject
    {
        public BodeAndazeGiri(string valueFarsi, string valueEnglish)
        {
            if (string.IsNullOrEmpty(valueFarsi) || string.IsNullOrWhiteSpace(valueFarsi))
                throw new InvalidBodeAndazeGiriException();

            if (string.IsNullOrEmpty(valueEnglish) || string.IsNullOrWhiteSpace(valueEnglish))
                throw new InvalidBodeAndazeGiriException();

            ValueFarsi = valueFarsi;
            ValueEnglish = valueEnglish;
        }

        public string ValueFarsi { get; private set; }
        public string ValueEnglish { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return ValueFarsi;
            yield return ValueEnglish;
        }
    }
}