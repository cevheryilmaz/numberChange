using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberChange
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 5;
            int number2 = 10;

            Console.WriteLine("Previous Value");
            Console.WriteLine("Number 1={0}", number1);
            Console.WriteLine("Number 2={0}", number2);


            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            Console.WriteLine("_______________________________________");
            Console.WriteLine("Next Value");
            Console.WriteLine("Number 1={0}", number1);
            Console.WriteLine("Number 2={0}", number2);

            Console.ReadKey();
        }
    }
}
