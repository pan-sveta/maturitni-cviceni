using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C15F
{
    //Třída je abstratní. Toto je nepovinné ale způsobí to to, že třída Vehicle jaktožto vozidlo NEJDE instancovat.
    //Až její děti (třídy které z Vehicle dědí) instancovat půjdou
    abstract class Vehicle
    {
        //Vlastnosti objektu. Mají private set aby se zvně objektu nedali upravovat, pouze uvnitř.
        public string Vyrobce { get; private set; }
        public string Model { get; private set; }
        public int Rok { get; private set; }
        public double Tachometr { get; private set; }
        public double Nadrz { get; private set; }
        public double Spotreba { get; private set; }

        //Klasický kontruktor, přiřadíme parametry konstruktoru do vlsastností
        public Vehicle(string vyrobce, string model, int rok, double tachometr,double nadrz, double spotreba)
        {
            Vyrobce = vyrobce;
            Model = model;
            Rok = rok;
            Tachometr = tachometr;
            Nadrz = nadrz;
            Spotreba = spotreba;
        }

        //Metoda, která přičte ujetou vzdálenost na tachometr a odečte palivo z nádrže na základě ujeté vzdálenosti
        public void Jet(double vzdalenost)
        {
            //Žertovný výpis toho že jedem
            Console.WriteLine("ŠKRRRRRR");

            //Přičteme ujetou vzdálenost na tachometr
            Tachometr += vzdalenost;
            
            //Z nádrže odečteme patřičné palivo
            Nadrz -= vzdalenost * (Spotreba / 100);

            //Nemůžeme mít záporný stav nádrže (samořejmě auto by se zastavilo dříve ale nemusíme být exaktní že)
            if (Nadrz<0)
            {
                Nadrz = 0;
            }
        }

        public void Natankovat(double palivo)
        {
            //Opět zvukový efekt 
            Console.WriteLine("Hůůůůůůůůůůů *tankování*");

            //Přičteme natankované palivo do nádrže
            Nadrz += palivo;
        }
    }
}
