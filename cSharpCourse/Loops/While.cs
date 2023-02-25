namespace cSharpCourse.Loops;

public static class While
{
    public static void doWhile()
    {
        int age;
        
        Console.Write("Enter Your age: ");

        age = Convert.ToInt32(Console.ReadLine());

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
        while (true)
        {
            Console.SetCursorPosition(0, 12);
            for (int i = 0; i < sectors.Length; i++)
            {
                Console.WriteLine($"There are {sectors[i]} places in sector {i+1}");
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}