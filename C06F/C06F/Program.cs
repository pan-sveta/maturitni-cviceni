using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C06F
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nejdřív musíte pochopit to algo. Ilustrační obrázek https://commons.wikimedia.org/wiki/File:Pi_30K.gif
            //Ve zkratce počet těch červenejch bodů děleno počtem všech bodů je zhruba pí
            //Poraďte si zapomocí internetu

            //Nadefinujeme si n - počet pokusů, r - poloměr a instacujme random generátor
            long n;
            double r;
            Random rand = new Random();

            //Načteme je pomocí příslušných metod z třídy Kalkulace (jsou uvedeny v zadání)
            Kalkulace.ZadejPolomer("poloměr", out r);
            Kalkulace.ZadejPocet("počet", out n);

            //Připravíme si proměnou která bude uchovávat počet bodů v kruhu
            double vKruhu = 0;

            //Uděláme smyčku která se bude opakovat n-krát
            for (int i = 0; i < n; i++)
            {
                //Náhodně vygenerujeme souřadnici x a y, přičítáme jedničku protože random generátor maximum o jedno sníží
                //r musíme přetypovat na int, Random nezchroupá double
                int x = rand.Next(0, (int)r + 1);
                int y = rand.Next(0, (int)r + 1);
                
                //Prakticky pomocí pythagorovi věty spočítáme přeponu pomyslného trojuhelníku
                //Chceme zjistit, zda-li je vzdálenost bodu od [0,0] úhlopříčně větší neo menší než poloměr
                double prepona = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

                //Ptáme se jestli je přepona menší nebo rovna poloměru, když jo přičteme jedničku do počtu bodů v kruhu
                if (prepona<=r)
                {
                    vKruhu++;
                }
            }

            //Nyní už pouze zjistíme poměr bodů. Počítali jsme čtvrtkruh proto násobíme čtyřmi!
            double pi = (vKruhu/n)*4;

            //Vypíšeme
            Console.WriteLine("V tomto případě Pí vychází na {0}.",pi);
            Console.ReadLine();
        }
    }
}
