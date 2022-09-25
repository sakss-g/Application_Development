using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Calculator
{
    public class Calculator
    {
        public static void Additions(int num1, int num2)
        {
            Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
        }

        public static void Subtraction(int num1, int num2)
        {
            Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
        }

        public static void Multiplication(int num1, int num2)
        {
            Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
        }

        public static void Division(int num1, int num2)
        {
            Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
        }

        public static int FirstNum() 
        {
            Console.WriteLine("Type a number, and then press Enter");
            int num1 = Convert.ToInt32(Console.ReadLine());

            return num1;
        }

        public static int SecondNum()
        {
            Console.WriteLine("Type a number, and then press Enter");
            int num2 = Convert.ToInt32(Console.ReadLine());

            return num2;
        }
    }
}
