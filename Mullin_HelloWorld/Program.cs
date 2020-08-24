using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mullin_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nicholas Scott Mullin");
            int num1 = 20;
            int num2 = 4;
            // Start dividing numbers by 4 until we hit 0
            for (int result = num1 / num2; result >= 0; result = num1 / num2)
            {
                Console.WriteLine(num1 + "/" + num2 + " = " + result);
                num1 -= num2;
            }
        }
    }
}