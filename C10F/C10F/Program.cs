using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Přidat using!
using System.Diagnostics;

namespace C10F
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopky = new Stopwatch();

            double[] poctyOperaci = { 5000000, 10000000, 50000000, 100000000 };
            for (int i = 0; i < 4; i++)
            {
                stopky.Start();
                for (long cislo = 0; cislo < poctyOperaci[i]; cislo++)
                {

                }
                stopky.Stop();
                Console.WriteLine("{0} operací za {1} sekund. Tzn. {2:0.00} MOPS.",poctyOperaci[i],stopky.Elapsed.TotalSeconds, poctyOperaci[i]/(double)stopky.Elapsed.TotalSeconds);
                stopky.Restart();
            }

            Console.ReadLine();
        }
    }
}
