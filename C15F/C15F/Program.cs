using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C15F
{
    class Program
    {
        static void Main(string[] args)
        {
            //NEJPRVE SI PROJDĚTE JEDNOTLIVÉ TŘÍDY

            //Instancujeme automobil
            Auto ferrari = new Auto("Ferrari", "Enzo", 2013, 14000, 120, 12.6, 2, 3);

            //Vypíšeme vozidlo
            Console.WriteLine(ferrari.ToString());

            //Popojedem xD
            ferrari.Jet(300);

            Console.WriteLine(ferrari.ToString());

            //Natankujeme
            ferrari.Natankovat(30);

            Console.WriteLine(ferrari.ToString());

            Console.ReadLine();
        }
    }
}
