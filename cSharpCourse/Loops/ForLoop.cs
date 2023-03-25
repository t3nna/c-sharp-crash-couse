namespace cSharpCourse.Loops;

public static class ForLoop
{
    public static int age = 12;
    public static void doForeach()
    {
        int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7 };

        //цикл с параметром 
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);

            
        }

        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}