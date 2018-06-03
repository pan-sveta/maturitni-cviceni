using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Using!!
using System.IO;

namespace C13F
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamWriter writer = new StreamWriter("soubor.txt");

                for (int i = 1; i <= 10; i++)
                {
                    writer.WriteLine(i.ToString());
                }
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Je nám líto, ale nastala chyba při vytváření souboru: {0}",e.Message);
                throw;
            }
            
            //Peek vrací ascii hodnotu následujícího charu aniž by ho zkonzumoval
            //"Neposune reader"
            if (File.Exists("soubor.txt"))
            {
                StreamReader reader = new StreamReader("soubor.txt");

                while (reader.Peek() > -1)
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("Je nám líto, ale soubor.txt neexistuje :(");
            }

            Console.ReadLine();
        }
    }
}
