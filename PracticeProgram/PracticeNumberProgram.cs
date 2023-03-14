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
    }
}
