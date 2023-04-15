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




           //ForLoop.doTree(); 
           int n;

           Console.WriteLine("enter number");
           n = Convert.ToInt32(Console.ReadLine());
           int a = 0;
           int b = 1;
           int c = 0;

           Console.WriteLine(a);
           Console.WriteLine(b);
           for (int i = 2; i < n; i++)
           {
               Console.WriteLine(a + b);
               c = b; 
               b += a;
               a = c;
           }













        }
    }
}