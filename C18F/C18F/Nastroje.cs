using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Musíme přidat using!
using System.Windows.Forms;

namespace C18F
{
    class Nastroje
    {
        public static void KreslitCtverce(Graphics g)
        {
            for (int i = 0; i < 5; i++)
            {
                int offset = 50 * i;
                //Asi to není nejelegatnější ale beat me
                g.DrawRectangle(Pens.Black,5+offset,5+offset, 500 - 2*offset, 500 - 2*offset);
            }
        }
    }
}
