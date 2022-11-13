using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.week2
{
    internal class IterationStatement
    {
        public static void DoWhileStatement(int num1)
        {
            do
            {
                Console.WriteLine(num1);
                num1++;
            }
            while (num1 < 10);
        }

        public static void ForLoop(int num1) 
        {
            for (int i = num1; i < 5; i++)
            { 
                Console.WriteLine(i);
            }
        }

        public static void ForEachLoop() 
        { 
            List <int> list = new List<int>() { 1, 2, 3, 4, 5};

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
