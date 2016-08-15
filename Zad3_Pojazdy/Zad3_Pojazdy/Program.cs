using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3_Pojazdy
{
    class Program
    {
        static void Main(string[] args)
        {

            var osobowy = new SamochodOsobowy("test", 1234, "PL", 12);
            var ciezarowy = new SamochodCiezarowy("test", 1234, "PL", 12);
            var motocykl = new Motocykle("test", 1234, "PL", 12);
        }
    }
}
