namespace cSharpCourse;

public static class IfElse
{
    private static int age = 12;

    public static void doIf()
    {
        // int age;
        // Console.WriteLine("Enter your age");
        // age = Convert.ToInt32(Console.ReadLine());
        // if (age >= 18)
        // {
        //     Console.WriteLine("Welcome to our bar!");
        //     Console.WriteLine("What would you like to drink!");
        // }
        // else
        // {
        //     Console.WriteLine("Sorry, you are too young!");
        //     Console.WriteLine("Come to us in " + (18-age) + " years");
        // }
        //
        // Console.WriteLine("Goodbye!");
        int age = 44;
        Console.WriteLine(age);

        string dayOfWeek;

        Console.WriteLine("Enter day of week: ");
        dayOfWeek = Console.ReadLine();

        if (dayOfWeek == "mon")
        {
            Console.WriteLine("Monday");
        }

        else if (dayOfWeek == "tue")
        {
            Console.WriteLine("Tuesday");
        }

        else if (dayOfWeek == "wed")
        {
            Console.WriteLine("Wednesday");
        }
        else
        {
            Console.WriteLine("Error 404");
        }
    }
}