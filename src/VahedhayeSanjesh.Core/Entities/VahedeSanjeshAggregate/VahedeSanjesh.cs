using System.Collections.Generic;

namespace VahedhayeSanjesh.Core.Entities.VahedhayeSanjesh
{
    public class VahedeSanjesh
    {
        public VahedeSanjeshePaye Paye { get; private set; }
        public IEnumerable<VahedeSanjesheFormoldar> Formoldars { get; private set; }
        public IEnumerable<VahedeSanjesheZaribdar> Zaribdars { get; private set; }
    }
}