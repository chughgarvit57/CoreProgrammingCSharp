using System.ComponentModel;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CoreProgrammingBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* ------------------- 1.Conditional Statements --------------------------
            Q1: Write a C# program that takes an integer as input and checks whether it is positive, negative, or zero.
            Q2: Write a program that takes a user's age and determines if they are eligible to vote (18 and above).
            */
            // Q1.
            /*Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine($"{num} is positive.");
            }
            else if (num < 0)
            {
                Console.WriteLine($"{num} is negative.");
            }
            else
            {
                Console.WriteLine($"{num} is 0.");
            }*/
            // Q2.
            /*Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 0 || age == 0)
            {
                Console.WriteLine("Age can't be negative or zero.");
            } else if (age >= 18)
            {
                Console.WriteLine("Eligible to vote!");
            } else
            {
                Console.WriteLine("Not eligible to vote.");
            }*/

            /*-------------------2.For, Do While, While Loops--------------------------
            Q1: Write a program to print all even numbers from 1 to 100 using a for loop.
            Q2: Use a while loop to calculate the sum of digits of a given number.
            Q3: Write a program using a do -while loop that keeps asking for a password until the correct one is entered.*/
            // Q1.
            /*for(int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }*/
            // Q2.
            /*int n = 571;
            int sum = 0;
            while (n > 0)
            {
                int digit = n % 10;
                sum += digit;
                n /= 10;
            }
            Console.WriteLine(sum);*/
            // Q3.
            /*string correctPassword = "garvit";
            string enteredPassword;
            do
            {
                Console.WriteLine("Enter password:");
                enteredPassword = Console.ReadLine();
                if (enteredPassword != correctPassword)
                {
                    Console.WriteLine("Incorrect password. Please try again.");
                }
            } while (enteredPassword != correctPassword);
            Console.WriteLine("Access Granted..!");*/

            // ------------------- 3.ArmStrong Numbers --------------------------
            /*Q1: Write a program to check if a given number is an Armstrong number(e.g., 153 → 1³ +5³ +3³ = 153).
            Q2: Generate all Armstrong numbers between 1 and 1000.*/
            // Q1.
            /*Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit * digit * digit;
                num /= 10;
            }
            if (sum == temp)
            {
                Console.WriteLine($"{temp} is an armstrong number.");
            }
            else
            {
                Console.WriteLine($"{temp} is not an armstrong number.");
            }*/
            // Q2.
            /*for (int i = 1; i <= 1000; i++)
            {
                int sum = 0;
                int num = i;
                while (num > 0)
                {
                    int digit = num % 10;
                    sum += digit * digit * digit;
                    num /= 10;
                }
                if(sum == i)
                {
                    Console.WriteLine(i);
                }
            }*/
            // ------------------- 4. Perfect Number & Happy Number --------------------------
            /*Q1(Perfect Number): Write a program to check whether a given number is a perfect number
            (a number equal to the sum of its proper divisors).
            Q2(Happy Number): Write a program to check whether a number is a happy number
            (sum of squares of digits eventually reaches 1).*/
            // Q1.
            /*Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (num == sum)
            {
                Console.WriteLine($"{num} is a perfect number.");
            } else
            {
                Console.WriteLine($"{num} is not a perfect number.");
            }*/
            // Q2.
            /*            Console.Write("Enter a number: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        int temp = num;
                        int sum = 0;
                        while (num != 1 && num != 4)
                        {
                            while (num > 0)
                            {
                                int digit = num % 10;
                                sum += digit * digit;
                                num /= 10;
                            }
                            num = sum;
                            sum = 0;
                        }
                        if (num == 1)
                        {
                            Console.WriteLine($"{temp} is a happy number.");
                        }
                        else
                        {
                            Console.WriteLine($"{temp} is not a happy number.");
                        }*/
            // ----------------------------- 5.Operators, Increment, Decrement ------------------------
            // Q1: Write a program to take two numbers as input and perform all arithmetic operations(+, -, *, /, %).
            /*int num1 = 10;
            int num2 = 5;
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            Console.WriteLine($"{num1} % {num2} = {num1 % num2}");*/
            // -------------------------------- 6. ARRAYS ---------------------------
            // Q. Write a program to find the maximum and minimum elements in an integer array.
            /*int[] num = { 1,2,5,8,7,6,3,9,4 };
            int max = num[0];
            int min = num[0];
            for (int i = 0; i < num.Length; i++) {
                if (num[i] > max)
                {
                    max = num[i];
                }
            }
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < min)
                {
                    min = num[i];
                }
            }
            Console.WriteLine($"Largest element: {max}");
            Console.WriteLine($"Minimum element: {min}");*/
            // --------------------------- PRIME NUMBER CHECK --------------------------------
            /*Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            for(int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"{num} is prime.");
            }
            else
            {
                Console.WriteLine($"{num} is not prime.");
            }*/
            // ---------------------------------- Remove Duplicates From Array -------------------------------
            /*int[] arr = { 1, 2, 3, 4, 2, 3, 5, 6, 7, 5, 8, 9, 1 };
            for(int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        arr[j] = -1;
                    }
                }
            }
            Console.WriteLine("After removing duplicates, arr is now:");
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != -1)
                {
                    Console.Write(arr[i] + " ");
                }
            }*/
            // ---------------------------------- Type Casting -----------------------------------
            // Implicit Type Casting (Smaller to Larger Type - Done Automatically)
            // int intNumber = 100;
            // double doubleNumber = intNumber; // Implicit conversion (int -> double)

            // Console.WriteLine("Implicit Type Casting:");
            // Console.WriteLine($"int: {intNumber} -> double: {doubleNumber}");

            // Explicit Type Casting (Larger to Smaller Type - Done Manually)
            // double largeNumber = 99.99;
            // int smallNumber = (int)largeNumber; // Explicit conversion (double -> int)

            // Console.WriteLine("\nExplicit Type Casting:");
            // Console.WriteLine($"double: {largeNumber} -> int: {smallNumber} (fractional part lost)");

            // Explicit Casting using Convert Class
            // string strNumber = "123";
            // int parsedNumber = Convert.ToInt32(strNumber); // Convert string to int

            // Console.WriteLine("\nExplicit Casting using Convert:");
            // Console.WriteLine($"string: \"{strNumber}\" -> int: {parsedNumber}");
            // ------------------------------- Fibonaccii Series --------------------------------
            /*Console.WriteLine("Enter number of terms in the series: ");
            int terms = Convert.ToInt32(Console.ReadLine());
            int first = 0;
            int second = 1;
            int third;
            for(int i = 1; i <= terms; i++)
            {
                Console.Write(first + " ");
                third = first + second;
                first = second;
                second = third;
            }*/
        }
    }
}
