using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProgram
{
    public class PracticeNumberProgram
    {
        public static void FindOddEven()
        {
            Console.WriteLine("Enter user input");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input % 2 == 0)
                Console.WriteLine("The given number {0} is even", input);
            else
                Console.WriteLine("The given number {0} is odd", input);
        }
        public static void OddNumWithinRange()
        {
            Console.WriteLine("Give the input range");
            int range = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= range; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine("The given number {0} is even", i);
            }
        }
    }
}
