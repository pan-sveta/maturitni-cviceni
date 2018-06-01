using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Using!!
using System.Text.RegularExpressions;

namespace C12F
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex telCislo = new Regex(@"[67]\d{2}[. -]*\d{3}[. -]*\d{3}");
            string text = @"Ahoj bejku moje telefoní číslo je 614478223. Nebo možná taky 781-514-124. Nebo lžu a je ti 619 257 114. Kdo ví ale rozhdoně to není 789.147.225.";

            MatchCollection shody = telCislo.Matches(text);

            foreach (Match shoda in shody)
            {
                Console.WriteLine(shoda.Value);
            }

            Console.ReadLine();
        }
    }
}
