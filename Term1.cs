using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Term1
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1= Int32.MaxValue;
            int val2=Int32.MaxValue;
            int val3;

            try
            {
                val3=checked(val1+val2);
                Console.WriteLine("val1 = {0}", val1);
                Console.WriteLine("val2 = {0}", val2);
                Console.WriteLine("sum of val1 and val2 = {0}", val3);
            }
            catch(OverflowException e){
                Console.WriteLine(e.ToString());
                Console.WriteLine("You are in the Checked Exception Block");
            }
            unchecked
            {
                val3 = val1 + val2;
            }
            Console.WriteLine("val1 = {0}", val1);
            Console.WriteLine("val2 = {0}", val2);
            Console.WriteLine("sum of val1 and val2 = {0}", val3);
            Console.WriteLine("You are in the Un-Checked Exception Block");
            Console.ReadKey();
        }
    }
}
