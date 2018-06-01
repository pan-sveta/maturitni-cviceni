using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C02F
{
    class Program
    {
        static void Main(string[] args)
        {
            //Modli se že si tohle nevytáhneš netuším co tím myslí a tak jsem to nějak splatlal dohromady
            //Tady ten systax foreache se musíš prostě naučit na to není pomůcka ale i tak nevím jestli je to dobře
            foreach (DatoveTypy datovyTyp in Enum.GetValues(typeof(DatoveTypy)))
            {
                switch (datovyTyp)
                {
                    case DatoveTypy.INT:
                        Console.WriteLine("{0} - Minimum: {1} Maximum: {2}","int",int.MinValue,int.MaxValue);
                        break;
                    case DatoveTypy.LONG:
                        Console.WriteLine("{0} - Minimum: {1} Maximum: {2}", "long", long.MinValue, long.MaxValue);
                        break;
                    case DatoveTypy.FLOAT:
                        Console.WriteLine("{0} - Minimum: {1} Maximum: {2}", "float", float.MinValue, float.MaxValue);
                        break;
                    case DatoveTypy.DOUBLE:
                        Console.WriteLine("{0} - Minimum: {1} Maximum: {2}", "double", double.MinValue, double.MaxValue);
                        break;
                    case DatoveTypy.DECIMAL:
                        Console.WriteLine("{0} - Minimum: {1} Maximum: {2}", "decimal", decimal.MinValue, decimal.MaxValue);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine();
            //Tohle je i zároveň odpověď na otázku v tom wordu
            //Když položíš char rovnej int do int se načte decimální hodnota toho znaku z ASCII tabulky
            //Prostě musíš znát
            for (int i = '0'; i <= '9'; i++)
            {
                Console.WriteLine("číslo: {0} - decimílně: {1} hexadecimálně {2}", char.ConvertFromUtf32(i),i,Convert.ToString(i,16));
            }
            Console.ReadLine();
        }

        //Syntaxe enumu nevím jak radit

        enum DatoveTypy
        {
            INT,
            LONG,
            FLOAT,
            DOUBLE,
            DECIMAL
        }
    }
    
}
