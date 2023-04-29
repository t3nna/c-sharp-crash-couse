namespace cSharpCourse.Loops;

public static class While
{
    public static void doWhile()
    {
        int age;
        
        Console.Write("Enter Your age: ");

        age = Convert.ToInt32(Console.ReadLine());
        // итерация - одно выполнение цыкла 
        // цикл с условием 
        while (age-- > 0)
        {
            if (age==8)
            {
                continue;
            }

            Console.WriteLine(age);
        }
    }

    public static void Fight()
    {
        int playerHealth = 100;
        int playerDamage = 10;
        
        int enemyHealth = 100;
        int enemyDamage = 10;

        decimal playerArmor, enemyArmor;
        
        while (playerHealth > 0 && enemyHealth > 0)
        {
            playerHealth -= enemyDamage;
            enemyHealth -= playerDamage;

            Console.WriteLine(playerHealth + " player");
            Console.WriteLine(enemyHealth + " enemy");
            
            
        }

        if (playerHealth <= 0 && enemyHealth <= 0)
        {
            Console.WriteLine("Ничья");
        }
        else if ( enemyHealth<=0)
        {
            Console.WriteLine("Победа Игрока");
        }
        else if (playerHealth<=0)
        {
            Console.WriteLine("Победа врага");
        }
        
        
        

        
    }

    
}