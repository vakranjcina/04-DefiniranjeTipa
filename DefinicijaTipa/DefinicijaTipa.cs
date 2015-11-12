using System;

namespace Vsite.CSharp
{
    class MojaKlasa
    {
        // Dodati jedna privatno polje (podatkovni član)
        private int x = 1;

        // Dodati javnu metodu koja će ispisati podatkovni član
        public int DajMiXa()
        {
            return this.x;
        }
    }


    struct MojaStruktura
    {
        // Dodati jedna privatno polje (podatkovni član)
        string s;

        // Dodati javnu metodu koja će ispisati podatkovni član
        public string DajMiStringa()
        {
            return s;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Inicijalizirati objekt tipa MojaKlasa i pozvati njegovu metodu
            MojaKlasa ak = new MojaKlasa();
            ak.DajMiXa();

            // Inicijalizirati objekt tipa MojaStruktura i pozvati njegovu metodu
            MojaStruktura ms = new MojaStruktura();
            ms.DajMiStringa();

            Console.ReadKey();
        }
    }
}
