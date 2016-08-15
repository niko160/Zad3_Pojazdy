using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3_Pojazdy
{
    abstract class Pojazd
    {

        public Pojazd(string marka, int rocznik, string krajPochodzenia)
        {
            this.Marka = marka;
            this.Rocznik = rocznik;
            this.KrajPochodzenia = krajPochodzenia;
        }

        public string Marka { get; set; }
        public int Rocznik { get; set; }
        public string KrajPochodzenia { get; set; }

        public virtual void Mycie()
        {
            Console.WriteLine("umyj pojazd");
        }
        
               


    }
}
