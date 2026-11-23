
// Uppgift 1
public class Program
{
    class mainprogram
    {
        Produkt Äpple = new Produkt("Äpple", 2.5f, 5.0f, 20);
        Produkt Mjölk = new Produkt("Mjölk", 10.0f, 15.0f, 10);
        Produkt Bröd = new Produkt("Bröd", 15.0f, 25.0f, 5);

        public mainprogram(Produkt Äpple, Produkt Mjölk, Produkt Bröd)
        {
            this.Äpple = Äpple;
            this.Mjölk = Mjölk;
            this.Bröd = Bröd;
        }
    }

    static void Main(string[] args)
    {
           
    }

    public class Produkt
    {
        public string Namn;
        public float KopPris;
        public float SaljPris;
        public int Antal;


        public Produkt(string Namn, float kopPris, float saljPris, int antal)
        {
            this.Namn = Namn;
            this.KopPris = kopPris;
            this.SaljPris = saljPris;
            this.Antal = antal;
        }

    }

}
