// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using cSharpCourse.Loops;
using cSharpCourse.Tasks;

namespace cSharpCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int triesCount = 5;
            // string password = "1234";
            // string userInput;
            //
            // for (int i = 0; i < triesCount; i++)
            // {
            //     Console.WriteLine("Enter Password");
            //     userInput = Console.ReadLine();
            //     if (userInput == password)
            //     {
            //         Console.WriteLine("My Gold!");
            //         break;
            //     }
            //     else
            //     {
            //         Console.WriteLine("Password is not correct");
            //         Console.WriteLine("You have " + (triesCount - i - 1) + "tries");
            //     }
            // }




            //
            // string password = "1234";
            // string userInput;
            // bool checker = true;
            // while (true)
            // {
            //     userInput = Console.ReadLine();
            //     
            //     if (password == userInput)
            //     {
            //         break;
            //     }
            //
            //     Console.WriteLine("Password is not correct");
            // }
            //
            // Console.WriteLine("You are in the system");
            //


            int a;
            int b;
            int c;
            while (true)
            {
                Console.WriteLine("Enter numbers");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter operation");
                Console.WriteLine("+ - amount");
                Console.WriteLine("- - difference");
                Console.WriteLine("* - multiplication");
                Console.WriteLine("/ - division");
                Console.WriteLine("0 - end program");
                string operation = Console.ReadLine();
                if (operation == "+")
                {
                    c = a + b;
                    Console.WriteLine($"{c}");
                }
                else if (operation == "-")
                {
                    c = a - b;
                    Console.WriteLine($"{c}");
                }
                else if (operation == "*")
                {
                    c = a * b;
                    Console.WriteLine($"{c}");
                }
                else if (operation == "/")
                {
                    if (b == 0)
                    {
                        Console.WriteLine("Error");
                    }
                    else
                    {
                        c = a / b;
                        Console.WriteLine($"{c}");
                    }
                }
                else if (operation == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Error");
                }


            }
        }
    }
}