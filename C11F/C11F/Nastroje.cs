using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C11F
{
    class Nastroje
    {
        public static void AnalyzovatHeslo(string heslo)
        {
            int pocetZnaku = heslo.Length;
            int pocetCisel = heslo.Count(Char.IsDigit);
            int pocetVelkychPismen = heslo.Count(Char.IsUpper);
            int pocetMalychPismen = heslo.Count(Char.IsLower);
            int pocetRidicichZnaku = heslo.Count(Char.IsControl);
            int pocetSpecialnichZnaku = heslo.Count(Char.IsPunctuation);

            Console.WriteLine("Heslo se skládá z:");
            Console.WriteLine("Jakékoli znaky:\t\t{0}", pocetZnaku);
            Console.WriteLine("Číslice:\t\t{0}", pocetCisel);
            Console.WriteLine("Velká písmena:\t\t{0}", pocetVelkychPismen);
            Console.WriteLine("Malá písmena:\t\t{0}", pocetMalychPismen);
            Console.WriteLine("Řídící znaky:\t\t{0}", pocetRidicichZnaku);
            Console.WriteLine("Speciální znaky:\t{0}", pocetSpecialnichZnaku);
        }
    }
}
