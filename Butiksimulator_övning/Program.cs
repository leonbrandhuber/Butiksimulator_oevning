
// Uppgift 1
using System.Globalization;

public class Program
{
    private static string kassa;

    static void Main(string[] args)
    {
        float kassa = 1000.0f;
        List<Produkt> lager = SkapaLager();
        bool korProgram = true;
        while (korProgram == true)
        {

            Console.WriteLine("------Butiksimulator-----");
            Console.WriteLine("Kassa: " + kassa + " kr");
            Console.WriteLine("1. Visa lager");
            Console.WriteLine("2. Köp produkt");
            Console.WriteLine("3. Sälj produkt");
            Console.WriteLine("4. Avsluta");
            Console.WriteLine("Välj ett alternativ: ");
            string val = Console.ReadLine();

            //VAd som sker när man väljer 1, 2 , 3, eller så
        }
    }

     static List<Produkt> SkapaLager()
    {
        List<Produkt> lager = new List<Produkt>();

        lager.Add(new Produkt("Äpple", 2.5f, 5.0f, 20));
        lager.Add(new Produkt("Mjölk", 10.0f, 15.0f, 10));
        lager.Add(new Produkt("Bröd", 15.0f, 25.0f, 5));
        return lager;
    }


     


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

    

    

    

    



