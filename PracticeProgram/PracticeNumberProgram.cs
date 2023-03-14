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
        public static void FindPosiNegNumber()
        {
            Console.WriteLine("Enter user input");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input > 0)
                Console.WriteLine("The number {0} is positive",input);
            else if (input < 0)
                Console.WriteLine("The number {0} is negative",input);
            else
                Console.WriteLine("The number {0} is zero",input);
        }
        public static void LargestOfTwoNumber(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
                Console.WriteLine("{0} is larger than {1}", firstNum, secondNum);
            else
                Console.WriteLine("{0} is larger than {1}", secondNum, firstNum);
        }

    }
}
