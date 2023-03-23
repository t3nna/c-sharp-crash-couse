namespace cSharpCourse.Collections;

public static class Stack
{
   public static void doStack()
   {
      Stack<int> numbers = new Stack<int>();
      
      numbers.Push(1);
      numbers.Push(2);
      numbers.Push(6);
      numbers.Push(15);
      numbers.Push(3);
      numbers.Push(234);

      Console.WriteLine(numbers.Peek());

      numbers.Pop();
      foreach (var number in numbers)
      {
         Console.WriteLine(number);
      }

      while (numbers.Count > 0)
      {
         Console.WriteLine("Next number in stack is: " + numbers.Pop());
      }

     
      
         
     
   } 
}