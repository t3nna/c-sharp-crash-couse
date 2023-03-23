namespace cSharpCourse;

public static class IncremDecrem
{
    public static void doOperators()
    {
        
        int a = 5;
        
        Console.WriteLine(a);

        Console.WriteLine(a++);

        Console.WriteLine(a);

        a = 5;

        
        // IncremDecrem
        Console.WriteLine(a);

        Console.WriteLine(++a);

        Console.WriteLine(a);

        Console.ReadKey();
        //i++; //i--;
        // Console.WriteLine(i++);
        //                0   +  ++1
        // Console.WriteLine(i++ + ++i);
        // Постфиксная форма, сначала возвращает, а после увлич или уменьш
        // Префиксная форма, сначала увлич или уменьш, а после возвращает 
        
        
        int x, w, k ;
        x = w = 3; 
        
        
        // k = (--x) + (w--);
        
        
        // w =(x--) + 10;

        
        w = 10 + (x--) + 3;

       Console.WriteLine(w);

    }
}