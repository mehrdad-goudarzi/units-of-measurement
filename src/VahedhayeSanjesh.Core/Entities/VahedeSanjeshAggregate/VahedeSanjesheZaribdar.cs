namespace VahedhayeSanjesh.Core.Entities.VahedhayeSanjesh
{
    public class VahedeSanjesheZaribdar : VahedeSanjeshBase
    {
        public VahedeSanjesheZaribdar(string nameFarsi, string nameEnglish, string symbol, BodeAndazeGiri bod,
            double nesbatBeVahedePaye) : base(nameFarsi, nameEnglish, symbol, bod)
        {
            NesbatBeVahedePaye = nesbatBeVahedePaye;
        }

        public double NesbatBeVahedePaye { get; private set; }
    }
}