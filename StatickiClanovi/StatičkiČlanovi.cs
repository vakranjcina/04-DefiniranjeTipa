using System;

namespace Vsite.CSharp
{
    class MojaKlasa
    {
        static int _brojač = 0;

        // U konstruktor dodati naredbu koja će uvećati _brojač za 1

        public MojaKlasa()
        {
            ++_brojač;
        }

        // U metodu dodati naredbu koja će ispisati trenutnu vrijednost člana _brojač

        public static void IspišiBrojInstanci()
        {
            Console.WriteLine(_brojač);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Nakon svakog poziva konstruktora pozvati metodu IspišiBrojInstanci()
            MojaKlasa mk1 = new MojaKlasa();
            MojaKlasa.IspišiBrojInstanci();

            MojaKlasa mk2 = new MojaKlasa();
            MojaKlasa.IspišiBrojInstanci();

            mk1 = new MojaKlasa();
            MojaKlasa.IspišiBrojInstanci();

            Console.ReadKey();
        }
    }
}
