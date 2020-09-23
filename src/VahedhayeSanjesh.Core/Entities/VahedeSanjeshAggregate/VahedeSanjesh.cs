namespace VahedhayeSanjesh.Core.Entities.VahedeSanjeshAggregate
{
    // پایه واحد سنجش
    public abstract class VahedeSanjesh
    {
        protected VahedeSanjesh(string nameFarsi, string nameEnglish, string symbol, BodeAndazeGiri bod)
        {
            NameFarsi = nameFarsi;
            NameEnglish = nameEnglish;
            Symbol = symbol;
            Bod = bod;
        }

        // نام فارسی
        public string NameFarsi { get; protected set; }
        // نام انگلیسی
        public string NameEnglish { get; protected set; }
        // سمبل
        public string Symbol { get; protected set; }
        // بعد اندازه گیری
        public BodeAndazeGiri Bod { get; protected set; }
    }
}
