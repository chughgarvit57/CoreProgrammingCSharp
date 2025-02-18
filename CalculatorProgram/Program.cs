using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace CalculatorProgram
{
    internal class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Sub(int a, int b)
        {
            return a - b;
        }
        static int Mul(int a, int b)
        {
            return a * b;
        }
        static int Divide(int a, int b)
        {
            return a / b;
        }
        static int Rem(int a, int b)
        {
            return a % b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Welcome To Apna Calculator App - Calculations Made Easy!\n");
            Console.WriteLine("Press the buttons according to your needs:");
            Console.WriteLine("1 --------------------> Addition");
            Console.WriteLine("2 --------------------> Subtraction");
            Console.WriteLine("3 --------------------> Multiplication");
            Console.WriteLine("4 --------------------> Division");
            Console.WriteLine("5 --------------------> Exit\n");
            while(true)
            {
                int res = 0;
                Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Press any button:");
                int button = Convert.ToInt32(Console.ReadLine());
                if (button == 5)
                {
                    Console.WriteLine("Thank You For Using Our Calculator. GoodBye!");
                    break;
                }
                switch (button)
                {
                    case 1:
                        res = Add(num1, num2);
                        break;
                    case 2:
                        res = Sub(num1, num2);
                        break;
                    case 3:
                        res = Mul(num1, num2);
                        break;
                    case 4:
                        if(num2 == 0)
                        {
                            Console.WriteLine("Error: Can't divide by zero");
                            break;
                        }
                        res = Divide(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid button. Please try again.");
                        break;
                }
                Console.WriteLine($"The result is: {res}");
                Console.WriteLine("Do you wish to continue (y/n)?");
                string confirmation = Console.ReadLine();
                if(confirmation == "n" || confirmation == "N")
                {
                    Console.WriteLine("Thank You For Using Our Calculator. GoodBye!");
                    break;
                }
            }
        }
    }
}
