namespace cSharpCourse.Functions;

public static class Resize
{
   public static void doResize()
   {
      int[] array1 = new int[5];
      int[,] array2 = new int[5, 5];
      array1 = ResizeArray(array1, 7);
      array2 = ResizeArray(array2, 10, 10);
      
      Console.WriteLine(array1.Length);
      Console.WriteLine(array2.Length);
   }

   static int[] ResizeArray(int[] array, int size)
   {
      int[] tempArray = new int[size];
      for (int i = 0; i < array.Length; i++)
      {
         tempArray[i] = array[i];
         
      }

      array = tempArray;
      return array;
   }
   
   // Если сигнатура ф-ции разная то мы можем создавать ее с одним и тем же именем 

   static int[,] ResizeArray(int[,] array,  int x, int y)
   {
      int[,] tempArray = new int[x, y];

      for (int i = 0; i < array.GetLength(0); i++)
      {
         for (int j = 0; j < array.GetLength(1); j++)
         {
            tempArray[i, j] = array[i, j];
         }
      }

      array = tempArray;
      return array;
   }
    
}