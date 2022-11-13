using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.week2
{
    internal class JumpStatement
    {
        public static void Jump()
        {
            Console.WriteLine("Enter a number");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number");
            var number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine($"{number1} is greater than {number2}");
                goto Apple;
            }
            else if (number1 < number2)
            {
                Console.WriteLine($"{number1} is less than {number2}");
            }
            else
            {
                Console.WriteLine($"{number1} is equal to {number2}");
            }

            Apple: Console.WriteLine("dasdsdfsz");

        }
    }
}
