namespace cSharpCourse;

public static class LogicalOperators
{
    public static void doOperators()
    {
        // Операторы сравнения 
        /*
         5==4 //false
         5==5   // true
         10 <= 10 // false 
         5!=5 // false
         
         */

        int age;

        age = Convert.ToInt32(Console.ReadLine());
        
        bool accessIsAllowed;

        accessIsAllowed = age >= 18; // true

        if (accessIsAllowed) // сравнение (age >= 18) 
        {
            Console.WriteLine("You can drink beer!");
        }
        else
        {
            Console.WriteLine("You are too young!");
        }
        

        Console.WriteLine(accessIsAllowed);
        
        
        
        Console.WriteLine(accessIsAllowed);
        




        // Операторы которые дают возможность создавть более сложные условия в if
        
        // Логическое И &&
        // Если хотябы один из операндов ноль, результат тоже будет 0
        int a = 10;
        if ( 5==5 && 4 == 5)
        {
            // do smth
        }
        else
        {
            // do smth
        }
        
        // x | y
        // 1 | 1    | 1
        // 1 | 0    | 0
        // 0 | 1    | 0
        // 0 | 0    | 0
        
        
        
        // Логическое Или ||
        // Если хотябы один из операндов 1, результат тоже будет 1
        // если хотябы одно условие 1, результат 1
        if ( 5<=4 || 4 > 4)
        {
            
        }
        else
        {
            
        }
        
        // x | y
        // 1 | 1    | 1
        // 1 | 0    | 1
        // 0 | 1    | 1
        // 0 | 0    | 0
        
        // Логическое исключающего ИЛИ
        // Возвращает true, если либо первый, либо второй операнд (но не одновременно) равны true, иначе возвращает false
        // x | y
        // 1 | 1    | 0
        // 1 | 0    | 1
        // 0 | 1    | 1
        // 0 | 0    | 0

        int money = 500;
        int level = 10;

        if (money >= 500) //|| level > 9)
        {
            if (level > 9)
            {
                Console.WriteLine("Приходи, добро пожаловать в нашу гильдию");
            }
        }
        else
        {
            Console.WriteLine("Вас выпнули");
        }


    } 
}