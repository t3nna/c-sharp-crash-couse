namespace cSharpCourse;

public class ElemConvert
{
    public static void doConvert()
    {
        int i = 0;
        int b = 4;
        double a = 7.4;
        int c;
        c = Convert.ToInt32(a);

        Console.WriteLine(c );
        
        // c = (7 + 4) / Convert.ToSingle(2);
        bool inBoolean = Convert.ToBoolean(5);
        Console.WriteLine();

        int age = Convert.ToInt32(Console.ReadLine());

        bool trigger = Convert.ToBoolean(age);
        Console.WriteLine("trigger "+trigger);

        Console.WriteLine($"I'm {age}");

        Console.WriteLine(inBoolean);
    }
    
}