namespace PracticeProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Practice Programs");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:Find odd or even number\n2:Odd number within range\n3:Find positive or negative number\n4:Find largest of two numbers\n5:Swap two numbers");
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
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}