using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vsite.CSharp
{
    class Bazna
    {
        public Bazna()
        {
            Inicijalizacija();
        }

        protected virtual void Inicijalizacija()
        {
            // dodati kod za inicijalizaciju članova bazne
            a = 10;
            b = "kazuya";
        }

        public int a;
        public string b;
    }

    class Izvedena : Bazna
    {
        public Izvedena()
        {
        }

        protected override void Inicijalizacija()
        {
            base.Inicijalizacija();
            // dodati kod za inicijalizaciju članova izvedene klase
            c = 3.14;
        }

        public double c;
    }

    class VirtualneMetodeKonstruktor
    {
        static void Main(string[] args)
        {
            // stvoriti po jednu instancu bazne i izvedene klase i provjeriti jesu li inicijalizirani svi njihovi članovi. Napraviti potrebne promjene.
            Bazna b = new Bazna();
            Izvedena i = new Izvedena();

            Console.ReadKey();
        }
    }
}
