using System;
using System;

namespace Vsite.CSharp
{
    class MojaKlasa
    {
        public MojaKlasa()
        {
            this.a = 25;
            this.s = "kazuya";
        }
        public MojaKlasa(int a, string s)
        {
            this.a = a;
            this.s = s;
        }
        public int a;
        public string s;
    }

    class KonstruktorKlase
    {
        static void Main(string[] args)
        {
            // Stvoriti objekt klase MojaKlasa i ispisati vrijednosti članova
            MojaKlasa mk = new MojaKlasa();
            Console.WriteLine(mk.a);
            Console.WriteLine(mk.s);


            // U klasu MojaKlasa dodati prazan konstruktor koji inicijalizira svoje članove na neku vrijednost te ponoviti gornji postupak
            MojaKlasa mk2 = new MojaKlasa();
            Console.WriteLine(mk2.a);
            Console.WriteLine(mk2.s);

            // U klasi MojaKlasa promijeniti prazan konstruktor tako da prima dva argumenta kojima se inicijaliziraju članovi te ponoviti gornji postupak
            MojaKlasa mk3 = new MojaKlasa(100, "most");
            Console.WriteLine(mk3.a);
            Console.WriteLine(mk3.s);

            Console.ReadKey();
        }
    }
}
