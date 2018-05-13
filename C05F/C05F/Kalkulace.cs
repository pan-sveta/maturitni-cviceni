using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05F
{
    class Kalkulace
    {
        //Metoda musí být statická aby jsme nemuseli třídu instancovat!
        public static int ZadejCislo(string zprava, int dolniMez, int horniMez)
        {
            int cislo;
            bool chyba;
            
            //"Pokus se převést text na číslo, do boolu chyba napiš zda-li se to povedlo a pokud ano vyhoď to do "cislo""
            chyba = !int.TryParse(zprava, out cislo);

            //Otestujeme, zda-li je číslo ve stanivených mezích
            if (cislo > horniMez || cislo < dolniMez)
            {
                chyba = true;
            }

            //V případě že nstane chyba vyhoď vyjímku

            if (chyba)
            {
                throw new Exception("Chybný formát vstupního řetězce.");
            }

            //Vrať číslo
            return cislo;
        }
    }
}
