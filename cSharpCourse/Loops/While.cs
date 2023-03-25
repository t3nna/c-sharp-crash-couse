namespace cSharpCourse.Loops;

public static class While
{
    public static void doWhile()
    {
        int age;
        
        Console.Write("Enter Your age: ");

        age = Convert.ToInt32(Console.ReadLine());
        // итерация - одно выполнение цыкла 
        // цикл с условием 
        while (age-- > 0)
        {
            if (age==8)
            {
                continue;
            }

            Console.WriteLine(age);
        }
    }

    public static void SeatsInPlane()
    {
        int[] sectors = { 4, 5, 74, 12, 5, 10 };
        bool isOpen = true;
        
        while (isOpen)
        {
            Console.SetCursorPosition(0, 19);
            for (int i = 0; i < sectors.Length; i++)
            {
                Console.WriteLine($"There are {sectors[i]} places in sector {i+1}");
            }
            
            Console.SetCursorPosition(0,0);
            Console.WriteLine("Registration");
            Console.WriteLine("\n\n1 - book places\n\n2 - exit from program.\n\n");
            Console.WriteLine("Enter command number: ");
            
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    int userSector, userPlaceAmount;
                    Console.Write("What sector do you want to pick?");
                    userSector = Convert.ToInt32(Console.ReadLine()) -1;
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

            Console.ReadKey();
            Console.Clear();
        }
    }
}