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


            //
            //
            // int[] arr = new[] { -2,-15, -30};
            //
            // int max = 0;
            // max = Int32.MinValue; // smallest value of max
            // max = arr[0]; 
            //
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     if (arr[i] > max)
            //     {
            //         max = arr[i];
            //     }
            // }
            //
            // Console.WriteLine(max);
            //
            //
            //
            //
            //
            // int[] arr2 = new int[10];
            //
            // for (int i = 0; i < arr2.Length; i++)
            // {
            //     // input from console 
            //     
            //     // если число делится на 5, записываем его в массив
            //     // есил число не делится на 5, записываем -1
            //     int temp = Convert.ToInt32(Console.ReadLine());
            //     if (temp % 5 == 0)
            //     {
            //         arr2[i] = temp;
            //     }
            //     else
            //     {
            //         i--;
            //     }
            //
            // }

            // int[] sectors = { 4, 5, 12, 30, 1, 3 }; // каждый элемент массива предстовляет собой колво мест в секторе
            // bool isOpen = true;
            // while (isOpen)
            // {
            //     Console.Clear();
            //     Console.SetCursorPosition(0, 19);
            //     for (int i = 0; i < sectors.Length; i++)
            //     {
            //         Console.WriteLine($"There are {sectors[i]} places in sector {i+1}");
            //
            //     }
            //     
            //     Console.SetCursorPosition(0, 0);
            //     Console.WriteLine("\n \n1 - book places\n\n2 - exist from program. \n\n");
            //     Console.WriteLine("Enter command number: ");
            //
            //     int choice = Convert.ToInt32(Console.ReadLine());
            //     if (choice == 1)
            //     {
            //         int userSector, userPlaceAmount;
            //         Console.WriteLine("What sector do you want to pick?");
            //         userSector = Convert.ToInt32(Console.ReadLine()) - 1;
            //         if (sectors.Length <= userSector || userSector < 0)
            //         {
            //             Console.WriteLine("This sector does no exist");
            //             Console.ReadKey();
            //             
            //             continue;
            //         }
            //         Console.Write("How much places do you want to book?");
            //         userPlaceAmount = Convert.ToInt32(Console.ReadLine());
            //         if (sectors[userSector] < userPlaceAmount || userPlaceAmount < 0)
            //         {
            //             Console.WriteLine($"In sector {userSector + 1} are not enough places"
            //             + $" There are only {sectors[userSector]} places"
            //             );
            //             
            //             Console.ReadKey();
            //             
            //             continue;
            //         }
            //
            //         sectors[userSector] -= userPlaceAmount;
            //         Console.WriteLine("You successfully book your tickets");
            //
            //     }
            //     else if (choice == 2)
            //     {
            //         isOpen = false;
            //     }
            //     else if (choice == 3)
            //     {
            //         
            //     }
            //
            //     Console.ReadKey();
            // }
            //

            // int[] bag = new int[1];
            // bag[0] = 12;
            // Console.WriteLine(bag.Length);
            // int[] tempBag = new int[bag.Length + 7]; // создаем новый массив 
            // for (int i = 0; i < bag.Length; i++)
            // {
            //     tempBag[i] = bag[i];
            // }
            // // записываем новое значение в расширенный массив 
            // tempBag[tempBag.Length - 1] = 144; //  
            //
            // bag = tempBag;
            //
            // for (int i = 0; i < bag.Length; i++)
            // {
            //     Console.WriteLine(bag[i]); 
            // }

            // int[] array = new int[3] { 1, 2, 3 };
            // int[] tempArray = { 9, 8, 2 };
            //
            // array = tempArray;
            //
            // Console.WriteLine("temp: " + tempArray[0] + "\narray: " + array[0]);
            // array[0] = 77;
            // tempArray[0] = 88;
            //
            // Console.WriteLine("temp: " + tempArray[0] + "\narray: " + array[0]);
            
            int[] array = new int[10];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int rnd = rand.Next(100);
                array[i] = rnd;
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("Index(ices) of what number do you want to find?");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you want to write number index to the new array?\n1 - Yes\n2 - No");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 2)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == num)
                    {
                        Console.WriteLine("You're number is under the index " + i);
                    }
                }
            }
            if (choice == 1)
            {
                int amount = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == num)
                    {
                        amount++;
                    }
                }
                int[] indices = new int[amount];
                int counter = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == num)
                    {
                        indices[counter] = i;
                        counter++;
                    }
                }

                Console.WriteLine("[");
                for (int i = 0; i < indices.Length; i++)
                {
                    Console.WriteLine(indices[i] + ", ");
                }

                Console.WriteLine("]");
            } 








        }
    }
}