namespace PracticeProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Practice Programs");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:Find odd or even number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    PracticeNumberProgram.FindOddEven();
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}