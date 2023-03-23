namespace cSharpCourse.Collections;

public static class List
{
    public static void doList()
    {
        List<int> numbers = new List<int>();
        
        numbers.Add(12);
        numbers.Add(13);
        numbers.Add(5);
        numbers.Add(18);
        
        numbers.AddRange(new int[] {3,4,5,6});
        
        numbers.RemoveAt(3);

        numbers.Remove(5);
        
        //numbers.Clear();

        Console.WriteLine("num 4 has index: " + numbers.IndexOf(4));
        
        numbers.Insert(1,123);
        

        for (int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        
    }
}