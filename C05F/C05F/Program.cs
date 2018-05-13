using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C05F
{
    class Program
    {
        static void Main(string[] args)
        {
            //Důrazně doporučuji navštivit https://cs.wikipedia.org/wiki/Eratosthenovo_s%C3%ADto a obeznámit se s tím, jak algorytmus funguje

            //Vytvoříme nekonečnou smyšku
            do
            {
                //Potychytáváme chybu, kterou nám v případě chybně zadaného formátu vyhodí metoda v třídě Kalkulace
                try
                {
                    Console.WriteLine("Zadejte horní mez [1-9999]: ");
                    int n = Kalkulace.ZadejCislo(Console.ReadLine(), 0, 10000);

                    List<int> prvocisla = new List<int>();

                    //Filtr potřebujeme včetně horní hranice. Tudíž když n=100, tak by pole mělo indexi pouze 0-99
                    bool[] filtr = new bool[n + 1];

                    //Procházíme všechna čísla od 2 (1 je zvláštní případ) až po horní mez n
                    for (int cislo = 2; cislo <= n; cislo++)
                    {
                        //Vyřadili jsme číslo v nějakém z přechozích kroků? Pokud ano (hodnota v poli je rovna true) můžeme ho přeskočit
                        if (filtr[cislo] != true)
                        {
                            bool jePrvocislo = true;

                            //Prochátíme všechny možné dělitele od dvou až po "cislo", ne včetně!
                            for (int delitel = 2; delitel < cislo; delitel++)
                            {
                                //Pokavaď má číslo dělitele, není prvočíslem, tj. zbytek po dělení (%) je roven 0
                                if (cislo % delitel == 0)
                                {
                                    jePrvocislo = false;
                                    //Break přeruší procházení dělitelů
                                    break;
                                }
                            }

                            //Pokud bylo číslo označeno jako prvočíslo
                            if (jePrvocislo)
                            {
                                //Přidáme ho do seznamu prvočísel
                                prvocisla.Add(cislo);

                                //A vyházíme z pole filtr jeho násobky
                                int nasobek = 2;

                                //Musíme ihned ověřit že číslo je menší než n aby nám pole nepřeteklo! a postupně vyhazujeme.
                                while (nasobek * cislo <= n)
                                {
                                    filtr[cislo * nasobek] = true;
                                    nasobek++;
                                }
                            }
                        }
                    }

                    //Vypíšeme
                    Console.WriteLine("Počet prvočísel v dánem rozsahu je {0}.", prvocisla.Count);
                }
                catch (Exception e)
                {
                    //Vypíšeme případnou zprávu vyjímky
                    Console.WriteLine(e.Message);
                }
            } while (true);
        }
    }
}
