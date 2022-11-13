using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.week2
{
    internal class SelectStatement
    {
        public static void IfELse()
        {
            Console.WriteLine("Enter a number");
            var number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a number");
            var number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine($"{number1} is greater than {number2}");
            }
            else if (number1 < number2)
            {
                Console.WriteLine($"{number1} is less than {number2}");
            }
            else
            {
                Console.WriteLine($"{number1} is equal to {number2}");
            }
        }

        public static void SwitchCase()
        {
            Console.WriteLine("Press 1 for Apple");
            Console.WriteLine("Press 2 for Orange");

            Console.WriteLine("Enter your choice");
            var option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Your choice is Apple");
                    break;
                case 2:
                    Console.WriteLine("Your choice is Orange");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        }
    }
}
