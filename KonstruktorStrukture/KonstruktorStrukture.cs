using System;

namespace Vsite.CSharp
{
    class KonstruktorStrukture
    {
        struct MojaStruktura
        {
            public MojaStruktura(int a, string s) {
                this.a = a;
                this.s = s;
            }
            //ctrl k u za komentiranje unkomentiranje
            public int a;
            public string s;
        }

        static void Main(string[] args)
        {
            // Stvoriti objekt strukture MojaStruktura i ispisati vrijednosti članova
            MojaStruktura ms = new MojaStruktura();
            Console.WriteLine(ms.a);
            Console.WriteLine(ms.s);

            // U strukturi MojaStruktura promijeniti prazan konstruktor tako da prima dva argumenta kojima se inicijaliziraju članovi te ponoviti gornji postupak
            MojaStruktura ms1 = new MojaStruktura(7, "satoshi");
            Console.WriteLine(ms1.a);
            Console.WriteLine(ms1.s);

            Console.ReadKey();

        }
    }
}
