namespace cSharpCourse;

public static class Switch
{
    public static void doSwitch()
    {
        string dayOfWeek;

        dayOfWeek = Console.ReadLine();

        switch (dayOfWeek)
        {
            case "Monday":
            case "Wednesday":
                Console.WriteLine("We are going to cinema");
                Console.WriteLine("Eating popcorn");
                break;
            case "Tuesday":
                Console.WriteLine("Cooking");
                break;
            // case "Wednesday"://error because of duplicate cases
            //     Console.WriteLine("Playing");
            default:
                Console.WriteLine("Wrong string");
                break;
            
        }
    }
}