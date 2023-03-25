using System.Text;

namespace cSharpCourse.Tasks;

public static class TasksForClass
{
    public static void DamageHealth()
    {
        // Console language fix
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;
        
        float health;
        int damage;
        int armor;
        int percentConverter = 100;

        Console.WriteLine("Enter the amount of health: ");
        health = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the amount of armor: ");
        armor = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the amount of damage: ");
        damage = Convert.ToInt32(Console.ReadLine());

        health = health - Convert.ToSingle( damage * armor / percentConverter);
        
        Console.WriteLine($"You got {damage} damage. You have {health} health.");

    }

    public static void Market()
    {
        int money;
        int food;
        
        bool isAbleToPay=false;
        int foodUnitPrice = 10;
        
        Console.WriteLine("Добро пожалывать в таверну! Сегодня еда по " + foodUnitPrice + "монет.");
        Console.WriteLine("How much gold do you have?");
        money = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How much food do you need?");
        food = Convert.ToInt32(Console.ReadLine());

        // isAbleToPay = money >= food * foodUnitPrice;
        if (money >= food * foodUnitPrice)
        {
            isAbleToPay = true;
        }

        food *= Convert.ToInt32(isAbleToPay);
        money -= food * foodUnitPrice;
        Console.WriteLine($"You have {food} smth in your bag and {money} gold!");
    }

    public static void MeasureDistance()
    {
        // int disToMars = 34000000, lightSpeed = 186000;
        // Console.WriteLine($"Delay time: \n{disToMars/lightSpeed}s\n{(disToMars/lightSpeed)/60.0}m");

        
        int distance = Convert.ToInt32(Console.ReadLine());
        int speed = Convert.ToInt32(Console.ReadLine());

        int time = distance / speed;

        //
        decimal timeInDecimal = Convert.ToDecimal(time);

        Console.WriteLine("decimal: " + timeInDecimal);
        
        //
        Console.WriteLine(time);

        
    
    }

    public static void PasswordCheck()
    {
        string password = "123abc";

        Console.WriteLine("Please enter the password");
        string userInput = Console.ReadLine();

        if (userInput == password)
        {
            Console.WriteLine("Password accepted! Hello user! ");
        }
        else
        {
            Console.WriteLine("Wrong password. Error 403");
        }
        

    }

    public static void PasswordCheckLoop()
    {
        int triesCount = 5;
        string password = "1234";
        string userInput;

        for (int i = 0; i < triesCount; i++)
        {
            Console.WriteLine("Enter Password");
            userInput = Console.ReadLine();
            if (userInput == password)
            {
                Console.WriteLine("My Gold");
            }
            else
            {
                Console.WriteLine("Password is not correct");
                Console.WriteLine("You have " + (triesCount - i - 1) + "tries");
            }
        }
    }

    public static void CurrencyConverter()
    {
       float plnInWallet, dollarsInWallet;

            float plnToUsd = 4.5f, usdToPln = 4.65f;

            float exchangeCurrencyCount;

            Console.WriteLine("Welcome to Currency Converter");

            Console.WriteLine("Enter your balance PLN");
            plnInWallet = Convert.ToSingle(Console.ReadLine());
            
            Console.WriteLine("Enter your balance USD");
            dollarsInWallet = Convert.ToSingle(Console.ReadLine());

            // Выбираем вариант
            Console.WriteLine("Select operation");
            Console.WriteLine("1 - pln to usd");
            Console.WriteLine("2 - usd to pln");

            string desiredOperation; //желаймая операция
            desiredOperation = Console.ReadLine();

            // выбираем операцию 1
            if (desiredOperation == "1")
            {
                Console.WriteLine("PLN to USD");
                Console.WriteLine("How much do you want to exchange?");
                exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine()); 
                
                if (plnInWallet >= exchangeCurrencyCount)
                {
                    plnInWallet -= exchangeCurrencyCount;
                    dollarsInWallet += exchangeCurrencyCount / plnToUsd;
                }
                // написать обработчик ошибок 
            }
            
            else if (desiredOperation == "2")
            {
                Console.WriteLine("USD to PLN");
                Console.WriteLine("How much do you want to exchange?");
                exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                
                if (dollarsInWallet >= exchangeCurrencyCount)
                {
                    dollarsInWallet -= exchangeCurrencyCount;
                    plnInWallet += exchangeCurrencyCount * usdToPln;
                }
                
                // написать обработчик ошибок
                
            }
            
            // написать обработчик ошибок (если пользователь введет неправильную операцию)
            
            
            // Дополнительно!!!!!
            // написать 3ю операцию:
            // если выбираем варинт 3 тогда мы кладем деньги на депозит под 15 %
            // вывести не экран сумму через год(доллары и злотые)
            

            Console.WriteLine(plnInWallet);
            Console.WriteLine(dollarsInWallet);

    }  
}