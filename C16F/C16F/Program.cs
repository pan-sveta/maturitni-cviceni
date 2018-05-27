using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C16F
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nejprve si projděte třídu Bod!
            //Zde není nic moc co vysvětlovat

            Bod prvni = new Bod(0, 0);
            Bod druhy = new Bod(3, 0);
            Bod treti = new Bod(3, 4);

            Bod ctvrty = prvni.Posunuti(3, 4);

            Console.WriteLine(prvni.Vzdalenost(treti));

            Console.WriteLine(treti.Vzdalenost(ctvrty));

            Console.WriteLine(treti.IsStejny(ctvrty,0.001));
            
            Console.ReadLine();
        }
    }
}
