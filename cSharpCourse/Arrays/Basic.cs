namespace cSharpCourse.Arrays;

public static class Basic
{
    public static void Declaration()
    {
        int[] numbers = { 4, 5, 7, 3, 44, 66, 99 };
        string[] friends = new string[10];

        friends[0] = "Tom";
        friends[1] = "Jim";

        Random rand = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(0, 101);
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine(friends.Length);
        // 2d Array
        int[,] numberGrid =
        {
            { 1, 2 },
            { 3, 4 },
            { 5, 6 }
        };

        //or 

        int[,] myArray = new int[2, 3];
        myArray[0, 0] = 12;

        Console.WriteLine(numberGrid[2, 1]);
    }

    public static void sumArray()
    {
        int[] array = { 1, 3, 6, 7, 8, 4, 23 };
        int sum = 0, maxElement = array[0]; // or we can use "int.MinValue"

        for (int i = 0; i < array.Length; i++)
        {
            // sum of the elements in the array
            sum += array[i];

            // max element 
            if (maxElement < array[i])
            {
                maxElement = array[i];
            }
        }

        Console.WriteLine("sum: " + sum);
    }

    public static void Expansion()
    {
        int[] bag = new int[1];
        bag[0] = 12;
        int[] tempBag = new int[bag.Length + 1];
        for (int i = 0; i < bag.Length; i++)
        {
            tempBag[i] = bag[i];
        }

        tempBag[tempBag.Length - 1] = 69;

        bag = tempBag;

        for (int i = 0; i < bag.Length; i++)
        {
            Console.WriteLine(bag[i]);
        }
    }


    public static void SeatsInPlane()
    {
        int[] sectors = { 4, 5, 74, 12, 5, 10 };
        bool isOpen = true;

        while (isOpen)
        {
            Console.SetCursorPosition(0, 19); // sets the printing position  
            for (int i = 0; i < sectors.Length; i++)
            {
                Console.WriteLine($"There are {sectors[i]} places in sector {i + 1}");
            }

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Registration");
            Console.WriteLine("\n\n1 - book places\n\n2 - exit from program.\n\n");
            Console.WriteLine("Enter command number: ");

            // convert it to int and give this exercise to the class 
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    int userSector, userPlaceAmount;
                    Console.Write("What sector do you want to pick?");
                    userSector = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (sectors.Length <= userSector || userSector < 0)
                    {
                        Console.WriteLine("This sector is not exist");
                        break;
                    }

                    Console.Write("How much places to you want to book?");
                    userPlaceAmount = Convert.ToInt32(Console.ReadLine());
                    if (sectors[userSector] < userPlaceAmount || userPlaceAmount < 0)
                    {
                        Console.WriteLine($"In sector {userSector} not enough places. There are only" +
                                          $"{sectors[userSector]} places");
                        break;
                    }

                    sectors[userSector] -= userPlaceAmount;
                    break;
                case 2:
                    isOpen = false;
                    break;
            }

            Console.ReadKey(); // terminates our while loop until the random button is pressed 
            Console.Clear();
        }
    }
}