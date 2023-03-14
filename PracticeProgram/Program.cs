namespace PracticeProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Practice Programs");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:Find odd or even number\n2:Odd number within range");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PracticeNumberProgram.FindOddEven();
                    break;
                case 2:
                    PracticeNumberProgram.OddNumWithinRange();
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}