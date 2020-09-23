namespace VahedhayeSanjesh.Core.Entities.VahedeSanjeshAggregate
{
    public class VahedeSanjesheFormoldar : VahedeSanjesh
    {
        public VahedeSanjesheFormoldar(string nameFarsi, string nameEnglish, string symbol, BodeAndazeGiri bod, FormoleTabdil formoleTabdilAzVahedePaye, FormoleTabdil formoleTabdilBeVahedePaye)
        : base(nameFarsi, nameEnglish, symbol, bod)
        {
            FormoleTabdilAzVahedePaye = formoleTabdilAzVahedePaye;
            FormoleTabdilBeVahedePaye = formoleTabdilBeVahedePaye;
        }

        public FormoleTabdil FormoleTabdilAzVahedePaye { get; private set; }
        public FormoleTabdil FormoleTabdilBeVahedePaye { get; private set; }
    }
}
