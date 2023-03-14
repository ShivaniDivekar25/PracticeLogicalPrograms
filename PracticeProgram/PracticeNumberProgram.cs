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
        public static void SwapTwoNumbers()
        {
            Console.WriteLine("Enter user input");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter user input");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numbers before swapping {0} and {1}", a, b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Numbers after swapping {0} and {1}", a, b);
        }
        public static void NumberDivisibleBy2()
        {
            Console.WriteLine("Enter user input");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input % 2 == 0)
                Console.WriteLine("The number {0} is divisible by 2", input);
            else
                Console.WriteLine("The number {0} is not divisible by 2", input);
        }
        public static void SumOfAllMultipleThreeAndFive()
        {
            int sum = 0;
            int a, b;
            for (int i = 1; i < 50; i++)
            {
                a = i % 3;
                b = i % 5;
                if (a == 0 || b == 0)
                {
                    Console.WriteLine("{0} ", i);
                    sum = sum + i;
                }
            }
            Console.WriteLine("The sum of all multiple of 3 or 5 are: " + sum);
        }
        public static void MultipleOfSeventeen()
        {
            int input;
            for (int i = 1; i < 100; i++)
            {
                input = i % 17;
                if (input == 0)
                {
                    Console.WriteLine("{0} is multiple of 17", i);
                }
            }
        }
        public static void SumOfDigit()
        {
            Console.WriteLine("Enter user input");
            int input = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int rem;
            while (input != 0)
            {
                rem = input % 10;
                input = input / 10;
                sum = sum + rem;
            }
            Console.WriteLine("Sum of digits of number: " + sum);
        }
        public static void ReverseNumber()
        {
            Console.WriteLine("Enter user input");
            int input = Convert.ToInt32(Console.ReadLine());
            int rem, rev = 0;
            while (input != 0)
            {
                rem = input % 10;
                rev = rem + rev * 10;
                input = input / 10;
                //rev = rev * 10;
                //rev = rev + input % 10;
                //input = input / 10;
            }
            Console.WriteLine("The reverse number is: {0}", rev);
        }
        public static void FindNumberPalindromeOrNot()
        {
            Console.WriteLine("Enter user input");
            int input = Convert.ToInt32(Console.ReadLine());
            int temp,rem, rev = 0;
            temp = input;
            while (input > 0)
            {
                rem = input % 10;
                rev = rem + rev * 10;
                input = input / 10;
            }
            if(temp == rev)
                Console.WriteLine("The given number is palindrome");
            else
                Console.WriteLine("The given number is not palindrome");
        }
        public static void SumOfTwoBinaryNum()
        {
            int count = 0, rem = 0;
            int[] sum = new int[20];
            Console.WriteLine("Enter first binary number:");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enetr second binary number:");
            int b2 = Convert.ToInt32(Console.ReadLine());
            while(b1 != 0 || b2 != 0)
            {
                sum[count++] = (b1 % 10 + b2 % 10 + rem) % 2;
                rem = (b1 % 10 + b2 % 10 + rem) / 2;
                b1 = b1 / 10;
                b2 = b2 / 10;
            }
            if(rem != 0)
            {
                sum[count++] = rem;
                --count;
                Console.WriteLine("Sum of two binary numbers: ");
            }
            while (count >= 0)
            {
                Console.Write("{0}", sum[count--]);
            }
        }
        public static void ArithmaticOperation()
        {
            Console.WriteLine("Enter first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int addition = num1 + num2;
            int substraction = num1 - num2;
            int multiplication = num1 * num2;
            int division = num1 / num2;
            Console.WriteLine($"Addition:{addition}, Substraction:{substraction},Multiplication: {multiplication}, Division:{division}");
        }
        public static void MulOfExponantOfSameBase()
        {
            Console.WriteLine("Enter the base value");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter first user input");
            double exp1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second user input");
            double exp2 = Convert.ToDouble(Console.ReadLine());
            double mul = exp1 + exp2;
            Console.WriteLine("Result is: {0}^{1}:{2}",num,mul,Math.Pow(num,mul));
        }
        public static void DivOfExponantOfSameBase()
        {
            Console.WriteLine("Enter the base value");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter first user input");
            double exp1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second user input");
            double exp2 = Convert.ToDouble(Console.ReadLine());
            double div = exp1 - exp2;
            Console.WriteLine("Result is: {0}^{1}:{2}", num, div, Math.Pow(num, div));
        }
        public static void MultiplicationTable()
        {
            Console.WriteLine("Enter user input");
            int input = Convert.ToInt32(Console.ReadLine());
            if( input < 0)
            {
                Console.WriteLine("Entered number is invalid");
            }
            else if(input > 0)
            {
                for(int i=1; i<=10; i++)
                {
                    Console.WriteLine($"{input} * {i} = {input * i}");
                }
            }
        }
    }
}
