using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06F
{
    class Kalkulace
    {
        //Proč metoda používá out když vrací jednu hodnotu na to se mě neptejte... musí

        //Metoda musí být statická aby jsme nemuseli třídu instancovat!
        public static void ZadejPolomer(string zprava, out double cislo)
        {
            string mujText;
            bool chyba;

            do
            {
                Console.Write("Zadej {0}: ",zprava);
                mujText = Console.ReadLine();

                //"Pokus se převést text na číslo, do boolu chyba napiš zda-li se to povedlo a pokud ano vyhoď to do "cislo""
                chyba = !double.TryParse(mujText, out cislo);

                //Ošetříme menší hodnoty, nemuseli by fungovat korektně
                if (cislo < 10)
                {
                    chyba = true;
                }
            } while (chyba);
        }

        //Metoda musí být statická aby jsme nemuseli třídu instancovat!
        public static void ZadejPocet(string zprava, out long cislo)
        {
            string mujText;
            bool chyba;

            do
            {
                Console.Write("Zadej {0}: ", zprava);
                mujText = Console.ReadLine();

                //"Pokus se převést text na číslo, do boolu chyba napiš zda-li se to povedlo a pokud ano vyhoď to do "cislo""
                chyba = !long.TryParse(mujText, out cislo);

                //Ošetříme menší hodnoty, nemuseli by fungovat korektně
                if (cislo < 1000)
                {
                    chyba = true;
                }
            } while (chyba);
        }
    }
}
