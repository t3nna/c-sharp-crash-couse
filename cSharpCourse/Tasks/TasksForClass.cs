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

    public static void CurrencyConverter()
    {
        float plnInWallet, dollarsInWallet;

        float plnToUsd = 4.4f, usdToPln = 4.6f;

        float exchangeCurrencyCount;
        string desiredOperation;

        Console.WriteLine("Welcome to Currency Converter");

        Console.WriteLine("Enter your balance in PLN");
        plnInWallet = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter your balance in USD");
        dollarsInWallet = Convert.ToSingle(Console.ReadLine());


        Console.WriteLine("Select operation");
        Console.WriteLine("1 - pln to usd");
        Console.WriteLine("2 - usd to pln");
        desiredOperation = Console.ReadLine();

        if (desiredOperation=="1")
        {
            Console.WriteLine("PLN to UDS");
            Console.WriteLine("How much do you want to exchange?");
            exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
            if (plnInWallet >= exchangeCurrencyCount)
            {
                plnInWallet -= exchangeCurrencyCount;
                dollarsInWallet += exchangeCurrencyCount / plnToUsd;
                
            }
            
            }
        else if (desiredOperation == "2")
        {
            
        }

        Console.WriteLine(plnInWallet);
        Console.WriteLine(dollarsInWallet);


    }  
}