namespace cSharpCourse;

public static class HandlingErrors
{
    public static void handlingErrors()
    {

        try
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 / num2);

        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Error");
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("This is exception");
            Console.WriteLine(e.Message);
            
        }
        finally
        {
            Console.WriteLine("Finish!");
        }
    }
}