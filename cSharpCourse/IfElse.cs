namespace cSharpCourse;

public static class IfElse
{
   

    public static void doIf()
    {
        // int age;
        //
        //
        // Console.WriteLine("Enter your age");
        // age = Convert.ToInt32(Console.ReadLine());
        //
        //
        // if (age >= 18)
        // {
        //     Console.WriteLine("Welcome to our bar!");
        //     Console.WriteLine("What would you like to drink!");
        // }
        // if (age==18)
        // {
        //     Console.WriteLine("You got gift cart");
        // }
        // else
        // {
        //     Console.WriteLine("Sorry, you are too young!");
        //     Console.WriteLine("Come to us in " + (18-age) + " years");
        // }
        //
        // Console.WriteLine("Goodbye!");
        //
        //
        //
        
        
        // int age = 44;
        // Console.WriteLine(age);
        //
        // string dayOfWeek;
        //
        // Console.WriteLine("Enter day of week: ");
        // dayOfWeek = Console.ReadLine();
        //
        //
        // if (dayOfWeek == "mon")
        // {
        //     Console.WriteLine("Monday");
        // }
        // if (dayOfWeek == "tue")
        // {
        //     Console.WriteLine("Tuesday");
        // }
        // if (dayOfWeek == "wed")
        // {
        //     Console.WriteLine("Wednesday");
        // }
        // else
        // {
        //     Console.WriteLine("Error 404");
        // }
        //
        //
        //
        //
        //
        // int fruits;
        // double fruitPrice=1;
        //
        // вчитать с консоли кол-во фруктов 
        
        // если кол-во фруктов меньше 50 - цена за ед. равна 10 злотых. 
        // если кол-во меньше 100 - цена 8 злотых 
        // если больше или равна 100 - цена 5.5 злотых
        // посчитать цену за фрукты
        
        // учитывать ошибки, если кол-во меньше 0 вывести ошибку 
        
        int fruits;
        double fruitprice;

        Console.WriteLine("how many fruits you wanna buy");
        fruits = Convert.ToInt32(Console.ReadLine());

        if (fruits <= 0)
            Console.WriteLine("error");
        
        else if (fruits < 50)
        {
            fruitprice = 10;
            Console.WriteLine(fruitprice * fruits);
        }

        else if (fruits < 100)
        {
            fruitprice = 8;
            Console.WriteLine(fruitprice*fruits);
        }

        else if (fruits >= 100)
        {
            fruitprice = 5.5;
            Console.WriteLine(fruitprice*fruits);
        }

        

        int abc = 49;

        var cda = "adljdfl;";
        
        
        
        
        
        // написать проверку пароля
        int password = 1234;
        int guess; 
        // проверка 
        // условие
        // если == "Доступ разрешен"
        // 




        Console.ReadKey();
    }
}