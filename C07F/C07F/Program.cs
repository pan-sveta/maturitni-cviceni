using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C07F
{
    class Program
    {
        static void Main(string[] args)
        {
            //Založíme proměnou pro počet pokusů
            int n;

            //Načteme počet pokusů metodou z třídy kalkulace
            Kalkulace.ZadejN("počet hodů",out n);

            //Vytvoříme si instanci náhodného generátoru
            Random rand = new Random();

            //Založíme si int pole o velikosti 6
            //Je to ale pole tudíž indexi bude mít 0-5 to je dobré si uvědomit
            int[] hody = new int[6];

            //Uděláme cyklus, který se bude opakovat 7-krát
            for (int i = 0; i < n; i++)
            {
                //Tady využijeme tríček
                //rand.Next(0,6) nám bude náhodně generovat čísla 0-5, což je pro nás velmi výhodné => odpovídá to indexům pole
                //Hodnotu v poli na tomto indexu pouze zvětšíme o jeden pomocí ++
                hody[rand.Next(0,6)]++;
            }

            //Začneme vypisovat
            Console.WriteLine("Pravděpodobnosti z {0} hodů vypadají následovně:",n);

            //Mohli by jsme vše ručně vypisovat, ale jsme přece programátoři (haha, pokud tohle musíš číst tak fakt ne)! Použijeme cyklus
            //Cyklus se bude opakovat 6 a i bude nabývat opět nám dobře známých hodnot 0-5
            for (int i = 0; i < 6; i++)
            {
                //Pro číslo na kostce musíme ovšem přičíst 1 protože kostka nemá čísla 0-5
                //Pomocí poměru hodů daného čísla a všech hodů vynásobeného stem získáme procetní poměr
                //inty musíme přetypovat před dělením na double aby nám dali desetinné číslo!
                Console.WriteLine("Číslo {0} má právděpodobnost {1}%.",i+1,((double)hody[i]/(double)n)*100);
            }

            Console.ReadLine();
        }
    }
}
