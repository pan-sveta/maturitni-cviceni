using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C09F
{
    class Program
    {
        //Regulérně jsem zde nenapsal ani jednu čárku, stačio dát 2x crtl+c ctrl+v
        static void Main(string[] args)
        {
            noCheckPreteceni();
            CheckIntPreteceni();
            try
            {
                deleniCheck(10, 0);
                volaniDeleni(10, 0);
                deleniNoCheck(10, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine("Main: {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Máme to všechno pod kontrolou!");
            }
            Console.ReadLine();

        }

        static void noCheckPreteceni()
        {
            int cislo1, cislo2;
            cislo1 = int.MaxValue;
            cislo2 = cislo1 + 1;
            Console.WriteLine("Bez kontroly int Max: {0:n0} přetečení: {1:n0}", cislo1, cislo2);
        }

        static void CheckIntPreteceni()
        {
            try
            {
                int cislo1, cislo2;
                cislo1 = int.MaxValue;
                cislo2 = checked(cislo1 + 1);
                Console.WriteLine("int Max: {0:n0} přetečení: {1:n0}", cislo1, cislo2);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Kontrola int přetečení: {0}", e.Message);
            }
        }

        static void deleniCheck(int cislo, int nula)
        {
            try
            {
                int vysledek = cislo / nula;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Procedura: {0}", e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("General {0}", e.Message);
            }
        }

        static void deleniNoCheck(int cislo, int nula)
        {
            int vysledek = cislo / nula;
        }

        static void volaniDeleni(int cislo, int nula)
        {
            try
            {
                deleniNoCheck(cislo, nula);
            }
            catch (Exception e)
            {
                Console.WriteLine("Volani: {0}", e.Message);
            }
        }

    }
}
