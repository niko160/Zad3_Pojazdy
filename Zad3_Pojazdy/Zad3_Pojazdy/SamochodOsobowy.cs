using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3_Pojazdy
{
    class SamochodOsobowy : WieloOsobowe
    {
        public SamochodOsobowy(string marka, int rocznik, string krajPochodzenia, int iloscOsobWPojezdzie) : 
            base(marka, rocznik, krajPochodzenia, iloscOsobWPojezdzie)
        {
        }

        public override void Mycie()
        {
            Console.WriteLine("Mycie i woskowanie samochodu osobowego");
        }

    }
}
