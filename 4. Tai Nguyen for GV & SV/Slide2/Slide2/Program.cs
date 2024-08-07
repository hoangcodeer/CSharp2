using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide2
{
   /* class Program
    {
        static void Main(string[] args)
        {
            var i = 100;
            Console.WriteLine("i value: {0}, type: {1}", i, i.GetType());
            var j = "Welcome to FPoly";
            Console.WriteLine("j value: {0}, type: {1}", j, j.GetType());
            var k = true;
            Console.WriteLine("k value: {0}, type: {1}", k, k.GetType());
            var l = 20.50;
            Console.WriteLine("l value: {0}, type: {1}", l, l.GetType());
            Console.ReadLine();
        }
    }*/
    class Program
    {
        static void Main(string[] args)
        {
            dynamic i = 100;
            Console.WriteLine("i value:{0}, type: {1}", i, i.GetType());
            dynamic j = "Welcome to FPoly";
            Console.WriteLine("j value:{0}, type: {1}", j, j.GetType());
            dynamic k = true;
            Console.WriteLine("k value:{0}, type: {1}", k, k.GetType());
            dynamic l = 20.50;
            Console.WriteLine("l value:{0}, type: {1}", l, l.GetType());
            Console.ReadLine();
        }
    }
    /* class Program
     {
         public delegate void Print(int value);
         static void Main(string[] args)
         {
             int i = 10;

             Print prnt = delegate (int val) {
                 val += i;
                 Console.WriteLine("Anonymous method: {0}", val);
             };

             prnt(100);
         }
     }*/
    /*public delegate void Print(int value);
    class Program
    {
        public static void PrintHelperMethod(Print printDel, int val)
        {
            val += 10;
            printDel(val);
        }
        static void Main(string[] args)
        {
            PrintHelperMethod(delegate (int val) { Console.WriteLine("Anonymous method: {0}", val); }, 100);
        }
    }*/

    class Program
    {
        // Create a delegate
        public void MathOps(int a);
        static void Main(string[] args)
        {
            int y = 10;
            // Instantiate the delegate using an anonymous method
            MathOps ops = (int x)
            {
                Console.WriteLine("Add Result: {0}", x + y);
                Console.WriteLine("Subtract Result: {0}", x - y);
            };
            ops(90);
            Console.ReadLine();
        }
    }
   
}
