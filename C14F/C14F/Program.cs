using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C14F
{
    class Program
    {
        static void Main(string[] args)
        {
            //UPOZORNĚNÍ: 3a a 3b neodpovídají zadání, podle mě je v něm chyba a proto nedochází ke kýženým výsledkům
            //Popis je v třídě

            //Nadefinujeme si proměné
            int cislo1 = 1, cislo2 = 2, cislo3 = 3, cislo4 = 4, cislo5 = 5, vysledek = 1000;

            //Metoda 1
            Console.WriteLine("Metoda 1:");
            Kalkulace.Metoda(ref vysledek, cislo1, cislo2, cislo3, cislo4);
            Console.WriteLine(vysledek);

            //Restartujeme proměné na výchozí hodnoty (není nutné dělat všude a vždy ale pro zjednodušení to dělám všude a vždy)
            cislo1 = 1; cislo2 = 2; cislo3 = 3; cislo4 = 4; cislo5 = 5; vysledek = 1000;

            //Metoda 2
            Console.WriteLine("Metoda 2:");
            Kalkulace.Metoda(out vysledek, cislo1, cislo2, cislo3);
            Console.WriteLine(vysledek);

            //Restartujeme proměné na výchozí hodnoty (není nutné dělat všude a vždy ale pro zjednodušení to dělám všude a vždy)
            cislo1 = 1; cislo2 = 2; cislo3 = 3; cislo4 = 4; cislo5 = 5; vysledek = 1000;

            //Metoda 3a
            Console.WriteLine("Metoda 3a:");
            vysledek = Kalkulace.Metoda(cislo1, cislo2, cislo3);
            Console.WriteLine(vysledek);

            //Restartujeme proměné na výchozí hodnoty (není nutné dělat všude a vždy ale pro zjednodušení to dělám všude a vždy)
            cislo1 = 1; cislo2 = 2; cislo3 = 3; cislo4 = 4; cislo5 = 5; vysledek = 1000;

            //Metoda 3a
            //Pojmenované parametry - Můžeme je dávat za přeskáčku pakliže jedadáváme ve tvaru jméno parametru:proměná
            Console.WriteLine("Metoda 3b:");
            vysledek = Kalkulace.Metoda(cislo3:cislo3*10,cislo2:cislo2*10,cislo1:cislo1*10);
            Console.WriteLine(vysledek);

            //Restartujeme proměné na výchozí hodnoty (není nutné dělat všude a vždy ale pro zjednodušení to dělám všude a vždy)
            cislo1 = 1; cislo2 = 2; cislo3 = 3; cislo4 = 4; cislo5 = 5; vysledek = 1000;

            //Metoda 4
            Console.WriteLine("Metoda 4:");
            vysledek = Kalkulace.Metoda(cislo1,cislo2,cislo3,cislo4,cislo5);
            Console.WriteLine(vysledek);

            //Restartujeme proměné na výchozí hodnoty (není nutné dělat všude a vždy ale pro zjednodušení to dělám všude a vždy)
            cislo1 = 1; cislo2 = 2; cislo3 = 3; cislo4 = 4; cislo5 = 5; vysledek = 1000;

            //Metoda 5
            Console.WriteLine("Metoda 5:");
            vysledek = Kalkulace.Metoda();
            Console.WriteLine(vysledek);

            Console.ReadLine();
        }
    }
}
