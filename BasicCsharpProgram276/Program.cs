using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCsharpProgram276
{
     class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter integer number to find even or odd");
            int input = Convert.ToInt32(Console.ReadLine());
            EvenOrOddNumbers.FindEvenOrOdd(input);
            Console.ReadLine();
        }
    }
}
