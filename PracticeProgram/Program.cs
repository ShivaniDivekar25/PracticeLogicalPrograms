namespace PracticeProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Practice Programs");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:Find odd or even number\n2:Odd number within range\n3:Find positive or negative number\n4:Find largest of two numbers\n5:Swap two numbers\n6:Find number divisible by 2\n7:Find sum of all multiple of 3 or 5");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PracticeNumberProgram.FindOddEven();
                    break;
                case 2:
                    PracticeNumberProgram.OddNumWithinRange();
                    break;
                case 3:
                    PracticeNumberProgram.FindPosiNegNumber();
                    break;
                case 4:
                    PracticeNumberProgram.LargestOfTwoNumber(23,69);
                    break;
                case 5:
                    PracticeNumberProgram.SwapTwoNumbers();
                    break;
                case 6:
                    PracticeNumberProgram.NumberDivisibleBy2();
                    break;
                case 7:
                    PracticeNumberProgram.SumOfAllMultipleThreeAndFive();
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}