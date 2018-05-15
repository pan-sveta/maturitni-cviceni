using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07F
{
    class Kalkulace
    {
        //Metoda musí být statická aby jsme nemuseli třídu instancovat!
        public static void ZadejN(string zprava, out int n)
        {
            string mujText;
            bool chyba;

            do
            {
                Console.Write("Zadej {0}: ", zprava);
                mujText = Console.ReadLine();

                //"Pokus se převést text na číslo, do boolu chyba napiš zda-li se to povedlo a pokud ano vyhoď to do "cislo""
                chyba = !int.TryParse(mujText, out n);

                //Ošetříme menší hodnoty
                if (n < 3)
                {
                    chyba = true;
                }
            } while (chyba);
        }
    }
}
