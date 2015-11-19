using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    class MojaKlasa
    {
        public MojaKlasa(int broj)
        {
            _broj = broj;
        }

        public int _broj;
    }

    struct MojaStruktura
    {
        public MojaStruktura(int broj)
        {
            _broj = broj;
        }

        public int _broj;
    }

    class Program
    {
        static void Main(string[] args)
        {
            MojaKlasa mk1 = new MojaKlasa(1);
            MojaKlasa mk2 = mk1;
            mk2._broj = 2;
            // Ispisati član _broj za obje instance te obrazložiti rezultat
            Console.WriteLine("mk1: " + mk1._broj+ " mk2: " + mk2._broj);
            /*
             * mk1: 2 mk2: 2
             * mk1 smo instancirali sa brojem 1, pa smo pridružili taj broj mk2
             * zato što smo promjenili mk2 na broj 2, oba dvije instance su se promjenile
             * zato što u memoriji se ne spremaju sve instance nego samo jedna, zadnja aktualna
             */

            MojaStruktura ms1 = new MojaStruktura(10);
            MojaStruktura ms2 = ms1;
            ms2._broj = 15;
            // Ispisati član _broj za obje instance te obrazložiti rezultat
            Console.WriteLine("ms1: " + ms1._broj + " ms2: " + ms2._broj);
            /*
             * ms1: 10 ms2: 15
             * ms1 smo instancirali sa brojem 10, pa smo ga pridružili ms2
             * iako smo promjenili ms2 na broj 15, ms1 se nije promjenio zato što ga u memoriji čuvamo
             */

            Console.ReadKey();
            /*
             * Zaključak:
             * Struktura pamti sve izvršene instance, dok klasa pamti samo jednu instancu i to onu zadnju upotrebljenu.
             */
        }
    }
}
