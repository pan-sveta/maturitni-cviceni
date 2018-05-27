using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C16F
{
    class Bod
    {

        //Vlastnosti objektu. Mají private set aby se zvně objektu nedali upravovat, pouze uvnitř.
        public double X { get; private set; }
        public double Y { get; private set; }

        //Konstruktor tak zvaně přetížíme (viz úloha 14), stejný název metody ale jiná činnost

        //První pakliže disponujeme parametry x a y
        public Bod(double x, double y)
        {
            X = x;
            Y = y;
        }

        //Druhý pakliže chceme deělat bod na souřandicích 0,0 nevyužijeme žádný parametr
        public Bod()
        {
            X = 0;
            Y = 0;
        }

        //Třetí chceme-li defakto bod zkopírovat jako nový -> parametr konstruktoru bude jiný bod
        public Bod(Bod druhy)
        {
            X = druhy.X;
            Y = druhy.Y;
        }

        //Vzdálenost dvou bodů vypočítáme formulí když zabrouzdáte do paměti, je to odvoze od phytágorovky
        //Jako parametr přijímáme další bod
        //vrátí double reprezentující vzdálenost
        public double Vzdalenost(Bod druhy)
        {
            return Math.Sqrt(Math.Pow(druhy.X - X, 2) + Math.Pow(druhy.Y - Y, 2));
        }

        //Tady se obávám, že se na chvilku zastavíme... Někteří z vás dokonce ztroskotají
        //Double jak otakový je decentě hazradní datový typ
        //Pro většinu operací stačí ale není naprosto exaktní (tzn. že když vidíme 0.5 v paměti může být 0.50001)
        //Proto musíme zvolit tento nepříliš krásný přístup na porovnání přesností
        //Přesný datový typ je například decimal
        public bool IsStejny(Bod druhy, double presnost)
        {
            bool stejny = false;

            if (Math.Abs(X-druhy.X) < presnost && Math.Abs(Y - druhy.Y) < presnost)
            {
                stejny = true;
            }

            return stejny;
        }

        //V této metodě vrátíme nový bod (všimněte si, že využíváme předem vysvětlený konstruktor s dvěma vstupy) na základě posunutí
        public Bod Posunuti(double dx, double dy)
        {
            return new Bod(X + dx, Y + dy);
        }
    }
}
