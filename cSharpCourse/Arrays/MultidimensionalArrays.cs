namespace cSharpCourse.Arrays;

public static class MultidimensionalArrays
{
    public static void doArrays()
    {
        int[,] array;
        int[,] array2 = new int [2, 3];

        int[,] array3 =
        {
            { 2, 3, 4 },
            { 4, 5,7 }
        };

        int[,] array4 = new int[2, 3]
        {
            { 4, 5, 6 },
            { 2, 3, 4 }
        };

        
        Console.WriteLine(array4[1,0]);// expected value 2
        Console.WriteLine(array3.Length);// returns the full lenght of the array

        for (int i = 0; i < array3.GetLength(0); i++)
        {
            for (int j = 0; j < array3.GetLength(1); j++)
            {
                Console.Write(array3[i,j]+" ");
            }

            Console.WriteLine();
        }
    }
}