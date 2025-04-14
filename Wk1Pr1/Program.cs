using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            */

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
    }
}
