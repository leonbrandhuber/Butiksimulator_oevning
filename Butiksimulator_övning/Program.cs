public class Program
{

    static void Main(string[] args)
    {
           
    }

    public class Produkt
    {
        public string Namn;
        public string KopPris;
        public string SaljPris;
        public string Antal;

        public Produkt(string Namn, string kopPris, string saljPris, string antal)
        {
            this.Namn = Namn;
            this.KopPris = kopPris;
            this.SaljPris = saljPris;
            this.Antal = antal;
        }

    }

}
