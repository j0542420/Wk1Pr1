using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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

            

            // week 3, Ex1
            // using methods: a method is a block of code that performs a specific task, also known as a function

            int counter = 0;

            int running = 0;

            while (true) 
            {
                running++;
                if (checkPrime(running))
                {
                    Console.WriteLine(running);
                    counter++;
                }
            }

            

            // week 3, Ex2

            Console.WriteLine(calSumDigits(1234));
            

            // week 3, Ex3

            //Console.WriteLine(largestNumber(1, 2, 3));

            // week 3, Ex4

            // printMultiples(4, 40);

            // week 3, Ex5

            //Console.WriteLine(leapYear(2000)? "Leap Year": "Not Leap Year");

            Console.WriteLine(reverseString("Hello"));

            Console.WriteLine(IsPalindrome(reverseString("Hello")));

            // week 3, Ex6

            

            // calculator using methods

            // using methods from the methods folder that has Class1.cs file
            


            while (true)
            { 
                Console.WriteLine("Input the first number");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input the second number");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Input a number to select an operation");
                Console.WriteLine("1 for Addition");
                Console.WriteLine("2 for Subtraction");
                Console.WriteLine("3 for Multiplication");
                Console.WriteLine("4 for Division");
                Console.WriteLine("others for Exit");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option) 
                {
                    case 1:
                        Console.WriteLine("The result of addition is " + Add(num1, num2));
                        break;
                    case 2:
                        Console.WriteLine("The result of subtraction is " + Subtraction(num1, num2));
                        break;
                    case 3:
                        Console.WriteLine("The result of multiplication is " + Multiply(num1, num2));
                        break;
                    case 4:
                        Console.WriteLine("the result of division is " + Division(num1, num2));
                        break;
                    default:
                        Console.WriteLine("Exiting the calculator");
                        return;
                }
            }


            // week 3, Ex7
            Console.WriteLine("Input a celcius number to convert to Fahrenheit");
            double celcius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The temperature of " + celcius + " in Celcius to Fahrenheit is " + CelciusToFahrenheit(celcius).ToString("0.00"));

            // week 3, Ex 8
            Console.WriteLine(Factorial(5)); // 120

            // week 3, Ex 9

            double[] assignments = { 80, 90, 85, 70, 95 }; // declare and initialize the array
            double avgAssignment = Average(assignments); // call the method to calculate the average

            double[] midTerms = { 75, 80, 85 }; // declare and initialize the array
            double avgMidTerm = Average(midTerms); // call the method to calculate the average

            double[] finalExams = { 90, 85, 80 }; // declare and initialize the array
            double avgFinalExam = Average(finalExams); // call the method to calculate the average

            double finalGrade = CalculateFinalGrade(avgAssignment, avgMidTerm, avgFinalExam); // call the method to calculate the final grade

            Console.WriteLine("The final grade is " + finalGrade.ToString("0.00")); // display the result


            //calling CountVowels method
            
            Console.WriteLine("Number ov vowels in Hello " + CountVowels("Hello"));

            // Week 3, Ex 10


            for (int i = 0; i < 5; i++)
            {

                int[] dices = RollDice(); // call the method to roll the dice
                Console.WriteLine("First Number " + dices[0] + " Second Number " + dices[1]); // display the result

            }

            string can1="j", can2="o", can3="s";
            votes.Add(can1, 0); // add the candidate to the dictionary
            votes.Add(can2, 0); // add the candidate to the dictionary
            votes.Add(can3, 0); // add the candidate to the dictionary
            // who do you vote
            // switch case

            */

            // week 4, Ex 1

            int[] ints = new int[3];

            ints = InputArray(ints); // call the method to input the array
            PrintArray(ints); // call the method to print the array
            Console.WriteLine("The max value is " + FindMax(ints)); // call the method to find the max value

            SortArray(ints);
            Console.WriteLine("after sorting: ");
            PrintArray(ints); // call the method to print the array

            Console.WriteLine(Havings(ints, 5));

            Console.ReadLine();

        }
        static int[] InputArray(int[] anArray) 
        {
            int[] returnArray = new int[anArray.Length]; // declare a temp array
            for (int i = 0; i < anArray.Length; i++) 
            {
                Console.WriteLine("Input a value for element " +i); // prompt the user for input

                returnArray[0] = Convert.ToInt32(Console.ReadLine()); // proccess
            }
            return returnArray; // return array with input values
        }

        static void PrintArray(int[] anArray) 
        {
            foreach(var i in anArray)
            {
                Console.WriteLine(i); // display the result
            }
        }
        static int FindMax(int[] anArray) 
        {
            int max = anArray[0]; // assign the first element of the array to max

            foreach (var x in anArray) // compare all elements to max
            {
                if (x > max) // proccess
                {
                    max = x; // assign the value to max
                }
            }
            return max; // output
        }
        static int[] SortArray(int[] anArray) 
        {
            int[] retArray = new int[anArray.Length];
            int temp;
            for (int i =0; i<anArray.Length-1; i++) // start at the first element of the array
            {
                for (int j = i+1; j < anArray.Length; j++)  // compare with all numbers
                {
                    if (anArray[i] > anArray[j]) // change the sign to sort in descending order
                    {
                        // swap the values
                        temp = anArray[i];
                        anArray[i] = anArray[j];
                        anArray[j] = temp; 
                    }
                }
            }
            retArray = anArray;
            return retArray; // output
        }
        static bool Havings(int[] anArray, int aNumber)
        { 
            bool retVal = false; // declare variable to hold the result

            foreach (var x in anArray)
            { 
                if (x == aNumber) // if equal, conclude found or not found
                {
                    retVal = true;
                }
            }

            return retVal; // output
        }
        static Dictionary<string, int> votes = new Dictionary<string, int>(); // declare a dictionary to hold the votes
        static void CastVote(string candidateName) 
        {
            votes[candidateName] ++; // increment the vote count for the candidate
        }
        static void DisplayVotes()
        {
            foreach (var vote in votes) // iterate through the dictionary
            {
                Console.WriteLine(vote.Key + " has " + vote.Value + " votes"); // display the result
            }
        }
        static void ResetVotes()
        {
            Dictionary<string, int> temp = new Dictionary<string, int>();
            foreach (var x in votes) // iterate through the dictionary
            {
                temp[x.Key] = x.Value;
            }

        }



        static Random rnd = new Random();
        // method to rowl 2 dice
        public static int[] RollDice()
        {
            int[] retVal = new int[2]; // declare variable to hold the result
            //Random rnd = new Random(); // declare variable to hold the random number generator
            retVal[0] = rnd.Next(0, 7); // proccess
            retVal[1] = rnd.Next(0, 7); // proccess
            return retVal; // output
        }



        //method to count vowels
        static int CountVowels(string input) 
        {
            int retVal = 0; // declare variable to hold the result

            string vowels = "aeiou"; // declare variable to hold the vowels

            foreach (char c in input.ToLower())
            // proccess
            {
                if (vowels.Contains(c)) // check if the character is a vowel
                {
                    retVal++; // increment the count
                }
            }

            return retVal; // output
        }

        // method for grading assignment
        static double Average(double[] grades)
        {
            double retVal = 0; // declare variable to hold the result

            double sum = 0;
            foreach(var grade in grades)
            {
                sum += grade; // proccess
            }

            retVal = sum / grades.Length; // calculate the average

            return retVal;
        }
        // method to calculate the final grade
        static double CalculateFinalGrade(double assignments, double midTerms, double finalExam)
        {
            double retVal = 0; // declare variable to hold the result
            retVal = (assignments * 0.4) + (midTerms * 0.3) + (finalExam * 0.3); // proccess
            return retVal; // output
        }

        // method for factorial calculation using recursion
        static long Factorial(int n)
        {
            long retVal = 1; // declare variable to hold the result
            if (n == 0)
            {
                retVal = -1; // invalid input
            }
            else
            {

                for (int i = 1; i <= n; i++)
                {
                    retVal = retVal * i; // proccess
                } 
            }
            return retVal; // output
        }
        public static double CelciusToFahrenheit(double celcius)
        {
            return (celcius * 9 / 5) + 32;
        }
        /*
        // method for addition
        static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }
        static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        static double Division(double num1, double num2)
        {
            return num1 / num2;
        }
        // another method for addition
        static double Add1(double n1, double n2) => n1 + n2;
        */
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


