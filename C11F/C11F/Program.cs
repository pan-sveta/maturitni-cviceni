using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C11F
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Zadejte heslo: ");
                string heslo = Console.ReadLine();
                Nastroje.AnalyzovatHeslo(heslo);
                Console.WriteLine();
            } while (true);
        }
    }
}
