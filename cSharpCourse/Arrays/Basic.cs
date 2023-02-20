namespace cSharpCourse.Arrays;

public static class Basic
{
    public static void Declaration()
    {
          
        int[] numbers = { 4, 5, 7, 3, 44, 66, 99 };
        string[] friends = new string[10];

        friends[0] = "Tom";
        friends[1] = "Jim";

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
}