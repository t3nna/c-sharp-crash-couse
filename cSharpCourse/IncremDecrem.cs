namespace cSharpCourse;

public static class IncremDecrem
{
    public static void doOperators()
    {
        int i = 0;
        //i++; //i--;
        // Console.WriteLine(i++);
        //                0   +  ++1
        Console.WriteLine(i++ + ++i);
        // Постфиксная форма, сначала возвращает, а после увлич или уменьш
        // Префиксная форма, сначала увлич или уменьш, а после возвращает 

        int x, w, k;
        x = w = 3;
        k = (--x) + (w--);
        Console.WriteLine(k);


    }
}