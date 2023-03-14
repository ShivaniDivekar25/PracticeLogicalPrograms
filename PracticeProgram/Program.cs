namespace PracticeProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Practice Programs");
            Console.WriteLine("Please enter an option");
            Console.WriteLine("1:Find odd or even number\n2:Odd number within range\n3:Find positive or negative number\n4:Find largest of two numbers\n5:Swap two numbers\n6:Find number divisible by 2\n7:Find sum of all multiple of 3 or 5\n8:Find multiple of seventeen\n9:Sum of digit\n10:Reverse Number\n11:Check num is palindrome or not\n12:Sum Of two binary number\n13:Arithmatic operation\n14:Multiplication of exponant of same base");
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
                case 8:
                    PracticeNumberProgram.MultipleOfSeventeen();
                    break;
                case 9:
                    PracticeNumberProgram.SumOfDigit();
                    break;
                case 10:
                    PracticeNumberProgram.ReverseNumber();
                    break;
                case 11:
                    PracticeNumberProgram.FindNumberPalindromeOrNot();
                    break;
                case 12:
                    PracticeNumberProgram.SumOfTwoBinaryNum();
                    break;
                case 13:
                    PracticeNumberProgram.ArithmaticOperation();
                    break;
                case 14:
                    PracticeNumberProgram.MulOfExponantOfSameBase();
                    break;
                default:
                    Console.WriteLine("Please enter right option");
                    break;
            }
        }
    }
}