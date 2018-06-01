using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C03F
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1 = 10;
            int operand2 = 2;

            Console.WriteLine(operand1+operand2);
            Console.WriteLine(operand1-operand2);
            Console.WriteLine(operand1/operand2);
            Console.WriteLine(operand1*operand2);
            Console.WriteLine(operand1++);
            Console.WriteLine(operand1--);

            Console.WriteLine();

            Console.WriteLine(operand1<operand2);
            Console.WriteLine(operand1>operand2);
            Console.WriteLine(operand1<=operand2);
            Console.WriteLine(operand1>=operand2);
            Console.WriteLine(operand1==operand2);
            Console.WriteLine(operand1!=operand2);

            Console.WriteLine();

            bool operand3 = true;
            bool operand4 = false;

            Console.WriteLine(operand3&&operand4);
            Console.WriteLine(operand3||operand4);
            Console.WriteLine(!operand3);

            Console.ReadLine();
        }
    }
}
