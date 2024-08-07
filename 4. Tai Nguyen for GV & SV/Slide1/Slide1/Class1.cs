using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide1
{
    partial class clsCalculation
    {
        public void Multiplication(int a, int b)
        {
            Console.WriteLine("Output Multiplication is {0}", a * b);
        }

        public void Division(int a, int b)
        {
            Console.WriteLine("Output Division is {0}", a / b);
        }
    }

    class Fpoly
    { 
        static Fpoly()
        {
            Console.WriteLine("Static constructor");
        }
    }
}
