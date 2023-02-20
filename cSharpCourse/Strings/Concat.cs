namespace cSharpCourse.Strings
{


    public static class Concat
    {
        static string Name;
        public static void Combine()
        {
            string greeting = "Hi";
            string friend = "My friend";
            int age = 10;
            // priority chain:
            // number + number + string + string + (number + number )
            Console.WriteLine(4 + (33 + greeting + " ") + friend + (age + 10));
            Console.WriteLine($"{4 + 33}{greeting} {age + 13}");


        }
    }
}