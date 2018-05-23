using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C14F
{
    class Kalkulace
    {
        //Metoda 1
        //Parametr typu ref - "nasaje" proměnou do metody a upravuje její hodnotu, úprava se objeví i vně tělo metody
        public static void Metoda(ref int vysledek, int cislo1, int cislo2, int cislo3, int cislo4)
        {
            vysledek += cislo1 + cislo2 + cislo3 + cislo4;
        }

        //Metoda 2
        //Parametr typu out - "vyhazuje" parametr, který funguje stejně jako return
        //Výhoda - Z metody můžeme vracet i více než jednu proměnou
        public static void Metoda(out int vysledek, int cislo1, int cislo2, int cislo3)
        {
            vysledek = cislo1 + cislo2 + cislo3;
        }

        //Metoda 3ab
        //Klasická emtoda vracející součet
        public static int Metoda(int cislo1, int cislo2, int cislo3)
        {
            return cislo1 + cislo2 + cislo3;
        }

        //Metoda 4
        //Params - Neomezený počet; Při volání metody můžeme nastavit libovolný počet parametrů,
        // se kterými v tělu metody pracujeme jako s polem
        public static int Metoda(params int[] cisla)
        {
            int vysledek = 0;
            for (int i = 0; i < cisla.Length; i++)
            {
                vysledek += cisla[i];
            }

            return vysledek;
        }

        //Metoda 5
        //Volitelné parametry - Parametry kterým v "deklaraci" přiřadíme hodnoty jsou při volání nepoviné
        //Pakliže je nezadefinujeme mají výchozí hodnotu (tu za =)
        public static int Metoda(int cislo1 = 10, int cislo2 = 20, int cislo3 = 30, int cislo4 = 40, int cislo5=50)
        {
            return cislo1 + cislo2 + cislo3+cislo4+cislo5;
        }
}
}
