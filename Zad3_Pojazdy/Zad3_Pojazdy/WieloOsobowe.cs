using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3_Pojazdy
{
    abstract class WieloOsobowe : Pojazd
    {
        public WieloOsobowe(string marka, int rocznik, string krajPochodzenia, int iloscOsobWPojezdzie) : base(marka, rocznik, krajPochodzenia)
        {
            this.IloscOsobWPojezdzie = iloscOsobWPojezdzie;

        }

        public int IloscOsobWPojezdzie { get; set; }

        public void Odkurzanie()
        {
            Console.WriteLine("Odkurz samochód");
        }
    }
}
