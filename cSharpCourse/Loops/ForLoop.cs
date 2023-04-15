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

    public static void doTree()
    {
        int n = 4;
        for (int i = 1; i <= n; i++)
        {
            // выводим в консоль пробелы
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(".");
            }
           // выводим елочку  
            for (int k = 1; k <= 2 * i - 1; k++)
            {
                Console.Write("*");
            }
            
            Console.WriteLine();
        }
    }

    public static void doFibonacci()
    {
        int n = 10; // number of terms to display
        int a = 0, b = 1;
        Console.Write("{0} {1}", a, b);
        for (int i = 2; i < n; i++)
        {
            int c = a + b;
            Console.Write(" {0}", c);
            a = b;
            b = c;
        }
    }

    public static int fib(int n)
    {
        if (n == 0 || n == 1)
            return n;
        return fib(n - 1) - fib(n - 2);
    }
}