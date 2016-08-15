using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3_Pojazdy
{
    class Motocykle : Pojazd
    {
        public Motocykle(string marka, int rocznik, string krajPochodzenia, int maksymalnaPredkosc) : base(marka, rocznik, krajPochodzenia)
        {
            this.MaksymalnaPredkosc = maksymalnaPredkosc;

        }

        public int MaksymalnaPredkosc { get; set; }

        public void SprawdzHamulce()
        {
            Console.WriteLine("Sprawdź hamulce");
        }
    }
}
