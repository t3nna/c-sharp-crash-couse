namespace cSharpCourse;

public static class Scope
{
    public static void doScope()




    {


        int x, y, z;
        x = y = z = 100;
        
              //100
            x = x + 200;//300
            y = y - 300;
        y = 400; // 
        
        
        
        x *= 1;
        y = y + 3;
        
        // c // c++
        
        
        
        
        
        
        
        
      //тип название = присвоение
      Console.WriteLine("Minutes in Jan");
        int minutesJan = Convert.ToInt32(Console.ReadLine);
        Console.WriteLine("Minutes in Feb");

        int minutesFeb = Convert.ToInt32(Console.ReadLine);
        Console.WriteLine("Minutes in Mar");
        
        int minutesMar = Convert.ToInt32(Console.ReadLine);

        int sumMinutes = minutesJan + minutesFeb + minutesMar;

        int callPrice = sumMinutes * 2;

        double tax = callPrice * 0.2;

        Console.WriteLine($"Sum = {sumMinutes}, price =" +
                          $" {callPrice}, amount of tax {tax}");
        
        
        
        
       
        
        
        
        
      


    }
    
    
    
    
    
}