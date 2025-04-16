using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Wk1Pr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // ex 1
            Console.WriteLine("Hello World!");

            // ex 2
            // declare variables
            double num1, num2, result;
            Console.WriteLine("Input the value for number 1 ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the value for number 2 ");
            num2 = Convert.ToDouble(Console.ReadLine());

            // calculate the sum
            result = num1 + num2;
            // display the result
            Console.WriteLine("The reult of addition is " + result);

            // calculate the subtraction
            result = num1 - num2;
            // display the result
            Console.WriteLine("The reult of subtraction is " + result);

            // calculate the multiply
            result = num1 * num2;
            // display the result
            Console.WriteLine("The reult of multiply is " + result);

            // calculate the division
            result = num1 / num2;
            // display the result
            Console.WriteLine("The reult of division is " + result.ToString("0.00"));
            

            // ex 3
            // declare variables
            double radius, area, result;

            // prompt the user for input
            Console.WriteLine("Input the radius");
            radius = Convert.ToDouble(Console.ReadLine());

            // calculate the area
            area = Math.PI * Math.Pow(radius, 2);
            // display the result
            Console.WriteLine("The area of the circle is " + area.ToString("0.00"));

            

            // ex 4
            // declare variables
            double Celcius, Fahrenheit, result;

            Console.WriteLine("What is the temperature in Celcius? ");
            Celcius = Convert.ToDouble(Console.ReadLine());

            // calculate the Fahrenheit
            result = (Celcius * 9 / 5) + 32;
            // display the result
            Console.WriteLine("The temperature of " + Celcius + "in Celcius to Fahrenheit is " + result.ToString("0.00"));

            

            // ex 5
            // declare variables
            int integer;

            // prompt the user for input
            Console.WriteLine("Input a whole number");
            // asking the user for input
            integer = Convert.ToInt32(Console.ReadLine());

            // is the number even or odd
            if (integer % 2 == 0)
            {
                Console.WriteLine("It is an even number");
            }
            else 
            {
                Console.WriteLine("It is an odd number");
            }

            

            // ex 6

            // declare variables
            int YearAge, MonthAge;

            // prompt the user for input
            Console.WriteLine("Input your age in years");
            // asking the user for input
            YearAge = Convert.ToInt32(Console.ReadLine());

            // calculate the age in months
            MonthAge = YearAge * 12;
            // display the result
            Console.WriteLine("Your age in months is " + MonthAge);

            

            // ex 7
            // declare variables
            int Principal, Rate, Time, Interest;

            // prompt the user for input
            Console.WriteLine("What is your Pricipal Amount");
            // asking the user for input
            Principal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your Rate of Interest");
            // asking the user for input
            Rate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your Time in years");
            // asking the user for input
            Time = Convert.ToInt32(Console.ReadLine());

            // calculate the interest
            Interest = (Principal * Rate * Time);

            // display the result
            Console.WriteLine("The interest is " + Interest);

            // ex 8
            // declare variables
            int name;

            // prompt the user for input
            Console.WriteLine("What is your name");
            // asking the user for input
            name = Convert.ToInt32(Console.ReadLine());

            // display a welcome message with the name
            Console.WriteLine("Hello " + name);

            // ex 10

            // declare variables
            const string password = "Password123";
            string inputPassword = string.Empty;

            // prompt the user for input
            Console.WriteLine("What is your password");
            // asking the user for input
            inputPassword = Console.ReadLine();

            // check if the password is correct
            if (inputPassword == password)
            {
                Console.WriteLine("Correct Password! Welcome");
            }
            else
            {
                Console.WriteLine("Incorrect password! ");
            }
            

            // week 2, Ex1

            int number;
            Console.WriteLine("Input a whole number");
            number = Convert.ToInt32(Console.ReadLine());

            if (number > 0) 
            { 
                Console.WriteLine(number + " is a positive number");
            } else if (number<0)
            {
                Console.WriteLine(number + " is a negative number");
            }
            else
            {
                Console.WriteLine(number + " is zero");
            }

            Console.WriteLine((number % 2 == 0) ? "It is an even number" : "It is a odd number ");

            

            // week 2, Ex2
            int grade;

            Console.WriteLine("Input a numeric grade  (0-100)");
            grade = Convert.ToInt32(Console.ReadLine());

            int grade10 = grade/10;

            switch (grade10) 
            {
                case 10:
                    Console.WriteLine("You got a Grade of A.");
                    break;
                case 9:
                    Console.WriteLine("You got a Grade of A.");
                    break;
                case 8:
                    Console.WriteLine("You got a Grade of B.");
                    break;
                case 7:
                    Console.WriteLine("You got a Grade of C.");
                    break;
                case 6:
                    Console.WriteLine("You got a Grade of D.");
                    break;
                case 5:
                    Console.WriteLine("You got a Grade of F.");
                    break;
                default:
                    Console.WriteLine("You got a Grade of F.");
                    break;
            }

            Console.WriteLine("Input a number such as 1234");
            string input = Console.ReadLine();

            int sum = 0;

            foreach (char c in input)
            {
                Console.WriteLine(Convert.ToInt32(c));
                sum += Convert.ToInt32(c.ToString());
            }
            Console.WriteLine("The sum of the digits is " + sum);

            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();

            Console.WriteLine()

            

            // week 2, Ex3
            // declare variables
            var num = 0;
            // input
            Console.WriteLine("Input a number");
            num = Convert.ToInt32(Console.ReadLine());
            // proccess

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num*i}\t {num+1} x {i} = {(num+1) * i}\t {(num+2)} x {i} = {(num+3) * i}\t");
            }

            // output
            
            // week 2, Ex4

            // declare variables
            int guess;
            int comp;

            // inpout
            // process
            Random rnd = new Random();
            
            // output
            while (true) 
            {
                comp = rnd.Next(1, 10);
                while (true)
                {
                    Console.WriteLine("What is your guessing a number between 1 and 10");
                    guess = Convert.ToInt32(Console.ReadLine());
                    if (guess == comp)
                    {
                        Console.WriteLine("You win");
                    }
                    else if (guess > comp)
                    {
                        Console.WriteLine("Your guess is too high");
                    }
                    else
                    {
                        Console.WriteLine("Your guess is too low");
                    }
                }

                Console.WriteLine("Do you want to play again? (Y/N)");

                if (!Console.ReadLine().ToLower().StartsWith("y"))
                {
                    break;
                }
            }

            

            // week 2, Ex5

            // output

            //fibonacci sequence
            // declare variables
            int number = 0;

            Console.WriteLine("Input a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < number; i++)
            //{
            // Console.Write(Fibonacci(i) + " ");
            //}

            long sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += Fibonacci(i);
            }
            Console.WriteLine("The sum of the Fibonacci sequence is " + sum);

            // calculate the sum of n numbers of factorials starting at 1
            // 1!=1
            // 2!=1*2= 1!*2
            // 3!=1*2*3= 2!*3

            */

            // password validation

            //IsUpper() to check if character is upper case

            //IsLower() to check if character is lower case

            //IsDigit() to check if character is digit

            // declare
            string password = "";
            bool hasUpper=false, hasLower=false, hasDigit=false;

            Console.WriteLine("Input a password to validate");
            password = Console.ReadLine();

            if (password.Length < 8)
            {
                Console.WriteLine("Password must be at least 8 characters long");
            }
            else
            {
                foreach (char c in password)
                {
                    if (char.IsUpper(c)) 
                    {
                        hasUpper = true;
                    }

                    if (char.IsLower(c))
                    {
                        hasLower = true;
                    }

                    if (char.IsDigit(c))
                    {
                        hasDigit = true;
                    }
                }
                if (!hasUpper)
                {
                    Console.WriteLine("Password must contain at least 1 upper case letter");
                }
                if (!hasLower)
                {
                    Console.WriteLine("Password must contain at least 1 lower case letter");
                }
                if (!hasDigit)
                {
                    Console.WriteLine("Password must contain at least 1 digit");
                }
            }

            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$";
            if (Regex.IsMatch(password, pattern))
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Password is invalid");
            }

        }
        static int Fibonacci(int number)
        {
            int retVal = 0;
            if (number == 0) // fixed value
            {
                retVal = 0;
            }
            else if (number == 1) // fixed value
            {
                retVal = 1;
            }
            else
            {
                retVal = Fibonacci(number - 1) + Fibonacci(number - 2);
            }
            return retVal;
        }
        static int factorial(int number)
        {
            int retVal = 0;
            if (number == 1) // fixed value
            {
                retVal = 1;
            }
            else
            {
                retVal = factorial(number - 1) * number;
            }
            return retVal;
        }
    }
}
