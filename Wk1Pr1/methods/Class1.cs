using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk1Pr1.methods
{
    public class Methods
    {
        // method for addition
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }
        static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Division(double num1, double num2)
        {
            return num1 / num2;
        }
        // another method for addition
        static double Add1(double n1, double n2) => n1 + n2;
        static bool IsPalindrome(string str)
        {
            return (str == reverseString(str));
        }
        static string reverseString(string str)
        {
            string reversed = "";

            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //reversed += str[i];
            //}

            int starter = str.Length - 1; // declare variable to hold the starting index of the string

            while (starter >= 0) // proccess
            {
                reversed += str[starter]; // get the character at the starting index and add it to the reversed string
                starter--; // decrement the starting index
            }

            return reversed;


        }
        static bool leapYear(int year)
        {
            bool retVal = true; // declare variable to hold result to return
            if (year % 4 != 0)
            {
                retVal = false; // not a leap year
            }
            else if (year % 100 == 0) // divisible by 100
            {
                if (year % 400 != 0) // not divisible by 400
                {
                    retVal = false;
                }
            }

            return retVal;
        }
        static void printMultiples(int n, int boundry)
        {
            int i = 1; // declare
            while (i * n <= boundry) // proccess
            {
                Console.WriteLine(i * n);
                i++;
            }
        }
        static int largestNumber(int num1, int num2, int num3)
        {
            int max = num1; // declare

            max = (max < num2) ? num2 : max; // proccess
            max = (max < num3) ? num3 : max; // proccess

            //if (num1 > num2)
            //{
            //Console.WriteLine(num1);
            //}
            //if else (num2 > num3)
            //{ 
            //Console.WriteLine(num2);
            //}
            //if else (num3 > num1)
            //{ 
            //Console.WriteLine(num3);
            //}

            return max; // output
        }
        static int calSumDigits(int number)
        {
            int retVal = 0; // declare

            while (number % 10 > 0) // get the remainder
            {
                // proccess
                // get the last digit of the number and add it to the retVal
                // remove the last digit from the number by dividing it by 10

                retVal += number % 10;

                number /= 10;

                Console.WriteLine(number);
            }

            return retVal; // output
        }
        //static int fibonacci(int number)


        //static int factorial(int number)


        static bool checkPrime(int number)
        {
            bool retVal = true; // declare

            // proccess
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    retVal = false; // not a prime number

                }
            }
            return retVal; // output
        }
    }
}
