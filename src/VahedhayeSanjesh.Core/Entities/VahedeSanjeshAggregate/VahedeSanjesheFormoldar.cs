namespace VahedhayeSanjesh.Core.Entities.VahedhayeSanjesh
{
    public class VahedeSanjesheFormoldar : VahedeSanjeshBase
    {
        public VahedeSanjesheFormoldar(string nameFarsi, string nameEnglish, string symbol, BodeAndazeGiri bod)
        : base(nameFarsi, nameEnglish, symbol, bod)
        {
        }

        public string FormolAzPaye { get; private set; }
        public string FormolBePaye { get; private set; }
        public FormoleTabdil FormoleTabdilAzVahedePaye { get; set; }
        public FormoleTabdil FormoleTabdilBeVahedePaye { get; set; }
    }
}
