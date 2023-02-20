namespace cSharpCourse.Tasks;

public static class LeetCode
{
    public static int[] shuffleTheArray(int[] nums, int n )
    {
        int x = 0;
        int[] result = new int[nums.Length];
        for (int i = 0; i < result.Length; i++)
        {
            if (i % 2 == 0)
            {
                result[i] = nums[x];
                x++;
            }
            else
            {
                result[i] = nums[n];
                n++;
            }
        }
        return result;
        
    }

    public static void TwoSum(int[] nums, int target)
    {
        int[] res = new int[2]; 
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i+1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    // int[] res = { i, j };
                    Console.WriteLine("{0} {1}", i, j);
                }
            }
        }
    }

    public static void ConcatenationOfArray(int[] nums)
    {
        int n = nums.Length;
        int[] res = new int[n * 2];
        for (int i = 0; i < n; i++)
        {
            res[i] = nums[i];
            res[i + n] = nums[i];
            
        }

        for (int i = 0; i < res.Length; i++)
        {
            Console.WriteLine(res[i]);
        }
    }
    
    public static void Fruits()
    {
        byte apples = Convert.ToByte(Console.ReadLine());
        byte pears =  Convert.ToByte(Console.ReadLine());

        Console.WriteLine($"There are {Math.Pow(apples,pears)} fruits in the basket!");


    }
    
}