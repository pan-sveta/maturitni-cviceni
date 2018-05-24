using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C15F
{
    //Máme třídu Auto která DĚDÍ z třídy Vehicle
    //Dědí znamená že přejímá všechny vlastnosti, metody a evnety mateřské třídy
    class Auto : Vehicle
    {
        //Vlastnosti objektu. Mají private set aby se zvně objektu nedali upravovat, pouze uvnitř.
        public int PocetOsob { get; private set; }
        public int PocetDveri { get; private set; }

        //Zde to začíná být trochu složitější, tím myslím že mě to malinko zpomalilo to znamená, že pro Vás to bude jako Higgsův boson
        //V zásadě se jedná o to že i dědící třída musí mít v kontruktoru parametry pro konstruktor rodičovské třídy
        //K tomu slouží base, prakticky v naší třídě si nadefinujeme všechny parametry a pomocí :base pošleme požadované do kontruktoru mateřské třídy
        public Auto(string vyrobce, string model, int rok, double tachometr, double nadrz, double spotreba,int pocetOsob,int pocetDveri):base(vyrobce,model,rok,tachometr,nadrz,spotreba)
        {
            //Dále jen přiřadíme vlastnosti naší (dědící) třídy
            PocetOsob = pocetOsob;
            PocetDveri = pocetDveri;
        }

        //override = přepsání -> každý objekt má metodu ToString() my jí tímto přepíšeme aby vralea, co chceme my
        //V našem případě pomocí tring formatu vypíšeme všechny informace o voze a to zábavnou formou se slangovými výrazy
        public override string ToString()
        {
            return String.Format("Tohle libový žihadlo {0} od {1} z roku {2}. Má najeto {3} km a papá {4} na sto. Stav nádrže je {5} l. Má {6} dvěří a uveze {7} humanoidů.",Model,Vyrobce,Rok,Tachometr,Spotreba,Nadrz,PocetDveri,PocetOsob);
        }
    }
}
