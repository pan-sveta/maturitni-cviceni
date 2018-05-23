using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08F
{
    class Program
    {
        static void Main(string[] args)
        {
            //Založíme si List do kterého budeme ukládat objekty "Zavodnik"
            //Pojmenujeme si ji závodníci
            List<Zavodnik> zavodnici = new List<Zavodnik>();

            //Uděláme si nekonečný cyklus
            do
            {
                Console.Write("Zadej jméno závodníka: ");

                string jmeno = Console.ReadLine();

                //Když námi načtená proměná jmeno bude obsahovat slovo "KONEC"
                //ToUpper() převede všechny písmená na velká tzn. Konec=>KONEC
                if (jmeno.ToUpper()=="KONEC")
                {
                    //Přerušení našeho cyklu (kód bude pokračovat "pod ním")
                    break;
                }

                //Instancujeme si třídu Zavodnik a do konstruktoru pošleme námni načtenou proměnou jmeno
                Zavodnik zavodnik = new Zavodnik(jmeno);

                //Přidáme instancovaný objekt do listu se závodníky
                zavodnici.Add(zavodnik);
            } while (true);

            //Prázdnmý nový řádek
            Console.WriteLine();

            //"Projedeme" všechny závodníky v listu (ne ve smyslu pohlavního styku)
            //Při každém průchodu cyklu se nám daný závodník uloží do proměné zavodnik
            foreach (Zavodnik zavodnik in zavodnici)
            {
                //Vypíšeme jeho jméno, viz. ToString() definice v objektu
                Console.WriteLine(zavodnik.ToString());
            }

            Console.ReadLine();

        }
    }
}
