using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C01F
{
    class Kalkulace
    {
        public static void ZadejKoeficient(string zprava, out double koeficient, out bool IsKoeficientNula)
        {
            string mujText;
            bool chyba;
            do
            {
                Console.Write("Zadej {0}: ", zprava);
                mujText = Console.ReadLine();
                chyba = !double.TryParse(mujText, out koeficient);
            } while (chyba);

            IsKoeficientNula = false;
            if (koeficient == 0)
            {
                IsKoeficientNula = true;
            }
        }

        public static void ResitKvadratickaRovnice(double a, double b, double c, out string reseni)
        {
            double diskriminant = 0;
            diskriminant = b * b - 4 * a * c;
            if (diskriminant > 0)
            {
                diskriminant = Math.Sqrt(diskriminant);
                reseni = string.Format("x1= {0} x2= {1}", (-b + diskriminant) / 2 / a, (-b - diskriminant) / 2 / a);
            }
            else if (diskriminant < 0)
            {
                diskriminant = Math.Sqrt(-diskriminant);
                reseni = string.Format("x1= {0} {1} i  x2= {2} - {3} i", -b / 2 / a, diskriminant / 2 / a, -b / 2 / a, diskriminant / 2 / a);
            }
            else
            {
                reseni = string.Format("x1 = x2 = {0}", -b / 2 / a);
            }
        }

        public static void ResitPolynom(double a, double b, double c, bool aNula, bool bNula, bool cNula, out string reseni)
        {
            //Vlastně jen řešíš kvadratickou rovnici a řešíš co je nula a co ne
            //Když to jde vyřešit jako kvadratická použiješ tu jeho metodu na to co sis nakopčil
            //Když ne pořešíš sám

            if (aNula)
            {
                if (bNula)
                {
                    //1
                    if (cNula)
                    {
                        reseni = "Nekonečně řešení";
                    }
                    //3
                    else
                    {
                        reseni = "Nekonečně řešení";
                    }
                }
                else
                {
                    //2
                    if (cNula)
                    {
                        reseni = "x=0";
                    }
                    //4
                    else
                    {
                        reseni = String.Format("x={0}", -c / b);
                    }
                }
            }
            else
            {
                //5,6,7,8
                //Jakmile kvadratickej člen není nula tak je ti to jedno a vyjde to jako kvadratická
                ResitKvadratickaRovnice(a, b, c, out reseni);
            }
        }


    }
}
