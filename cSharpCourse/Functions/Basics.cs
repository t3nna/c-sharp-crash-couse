namespace cSharpCourse.Functions;

public static class Basics
{
    public static void doFunction()
    {
        /*
        Console.WriteLine("Hallo");
        // text - аргумент
        WriteError("Strange Error", ConsoleColor.Blue);
        Console.WriteLine("Are you here?");
        WriteError("", symbol: '#');
        */

        int sum=0,sum2, x = 1, y = 5;
        
        // когда мы передаем переменные в ф-цию мы передаем их значение, копируем их, 
        // поэтому все переменные должны быть проинициализированы 
        Add(ref sum, x, y);
        Console.WriteLine(sum);
        
        AddOut(out sum2, x, y);
        Console.WriteLine(sum2);

    }
    // void - пустота или отсутсвие | text - параметр 
    // необязательные параметры должны стоять в конце всех параметров
    static void WriteError(string text, ConsoleColor color = ConsoleColor.Red, char symbol = '!')
    {
        // taking default user color
        ConsoleColor defaultColor = Console.ForegroundColor;
        // changing message to red
        Console.ForegroundColor = color;
        if (text.Length>0)
        {
            Console.WriteLine(symbol+text);
        }
        else
        {
            Console.WriteLine("No Connection to Internet");
        }
        // returning to default color
        Console.ForegroundColor = defaultColor;
    }

    
    
    static void Add(ref int sum, int x, int y)
    {
        sum = x + y;
    }
    static void AddOut(out int sum, int x, int y)
    {
        sum = x + y;
    }

    static void EditArray(int[] array, int index, int value)
    {
        array[index] = value;
    }
}