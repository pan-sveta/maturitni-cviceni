using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01F
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double a, b, c;
                bool aNula, bNula, cNula;

                Kalkulace.ZadejKoeficient("koeficient a", out a, out aNula);
                Kalkulace.ZadejKoeficient("koeficient b", out b, out bNula);
                Kalkulace.ZadejKoeficient("koeficient c", out c, out cNula);

                string reseni;
                Kalkulace.ResitPolynom(a,b,c,aNula,bNula,cNula,out reseni);

                Console.WriteLine();
                Console.WriteLine(reseni);
                Console.WriteLine();
            } while (true);
        }
    }
}
