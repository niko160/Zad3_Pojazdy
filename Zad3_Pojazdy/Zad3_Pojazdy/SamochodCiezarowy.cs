using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3_Pojazdy
{
    class SamochodCiezarowy : WieloOsobowe
    {
        public SamochodCiezarowy(string marka, int rocznik, string krajPochodzenia, int iloscOsobWPojezdzie) : 
            base(marka, rocznik, krajPochodzenia, iloscOsobWPojezdzie)
        {
        }

        public void OdczepPrzyczepe()
        {
            Console.WriteLine("Odczep przyczepe");
        }

    }
}
