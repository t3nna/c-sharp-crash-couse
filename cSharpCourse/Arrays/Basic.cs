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
            {3,4},
            {5,6}
        };
        
        //or 

        int[,] myArray = new int[2, 3];
        myArray[0, 0] = 12;
        
        Console.WriteLine(numberGrid[2,1]);


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
}