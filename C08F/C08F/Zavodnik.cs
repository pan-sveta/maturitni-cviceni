using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08F
{
    class Zavodnik
    {
        //Vlastnost objektu typu string
        //Private set znamená že de nastavit POUZE zevnitř objektu
        public string Jmeno { get; private set; }

        //Konstruktor, metoda, která se volá při založení objektu
        //Má parametr jmeno typu string, musí se vpylnit při zakládání objektu
        public Zavodnik(string jmeno)
        {
            //Nastavíme vlastnost objektu Jmeno na vstupní parametr kostruktopru
            Jmeno = jmeno;
        }

        //override = přepsání -> každý objekt má metodu ToString() my jí tímto přepíšeme aby vralea, co chceme my
        //V našem případě vrací vlastnost Jmeno
        public override string ToString()
        {
            return Jmeno;
        }
    }
}
