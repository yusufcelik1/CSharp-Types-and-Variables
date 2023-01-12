using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");
            decimal number5 = 3.14m;
            double ondalikli = 3.14;
            char character = 'a';
            bool condition = true;
            byte number1 = 255;
            short number2 = -32768;
            int number3 = -2147483648;
            long number4 = -9223372036854775808;
            var var1 = 7;
            Console.WriteLine("Number 1 is {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}",
                number1,number2,number3,number4,condition,character,ondalikli,
                number5,Days.Sunday, var1);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday,Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
