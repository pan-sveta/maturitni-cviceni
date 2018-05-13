using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04F
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vytvoříme nekonečnou smyšku
            do
            {
                //Potychytáváme chybu, kterou nám v případě chybně zadaného formátu vyhodí metoda v třídě Kalkulace
                try
                {
                    Console.Write("Zadejte vstup [n t]: ");
                    string mujText = Console.ReadLine();

                    //Rozdělíme textový řetězec do pole na jednotlivé čísla stále v podobě textu
                    string[] cisla = mujText.Split(' ');

                    //Pomocí metody ZadejCislo převedeme jednotlivé položky v poli na čísla a načteme do proměné
                    int n = Kalkulace.ZadejCislo(cisla[0], 0, 1000);
                    int t = Kalkulace.ZadejCislo(cisla[1], 0, 12);

                    //V zásadě zjistíme po přečtění zadání, že se každou hodinu počet bakterií zdvojnásobí
                    //Načteme si proto první bakterie do proměné počet

                    int count = n;

                    //Nyní t-krát zdvojnásobíme počet

                    for (int i = 0; i < t; i++)
                    {
                        count *= 2;
                    }

                    Console.WriteLine("Konečný počet bakterií je: "+count);
                }
                catch (Exception e)
                {
                    //V případě že nastane vyjímka vypíšeme ji
                    Console.WriteLine(e.Message);
                }
            } while (true);
        }
    }
}
