namespace VahedhayeSanjesh.Core.Entities.VahedeSanjeshAggregate
{
    public class VahedeSanjesheZaribdar : VahedeSanjesh
    {
        public VahedeSanjesheZaribdar(string nameFarsi, string nameEnglish, string symbol, BodeAndazeGiri bod,
            double nesbatBeVahedePaye) : base(nameFarsi, nameEnglish, symbol, bod)
        {
            NesbatBeVahedePaye = nesbatBeVahedePaye;
        }

        public double NesbatBeVahedePaye { get; private set; }
    }
}