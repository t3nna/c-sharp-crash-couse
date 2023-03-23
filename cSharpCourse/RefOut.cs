namespace cSharpCourse;

public static class RefOut
{
    public static void doRefOut()
    {
        // int sum, x = 4, y = 5;
        // Add(out sum, x, y);
        // Console.WriteLine(sum);
        int[] array = new int [5];
        array = EditArray(array, 2, 5);
        Console.WriteLine(array[2]);
    }

    static void Add(out int sum, int x, int y)
    {
        sum = x + y;
    }

    static int[] EditArray(int[] array, int index, int value)
    {
        array = new int[6];
        array[index] = value;
        return array;
    }
    
}