namespace cSharpCourse.Collections;

public static class Dictionary
{
   public static void doDictionary()
   {
      Dictionary<string, string> countriesCapitals = new Dictionary<string, string>();
      countriesCapitals.Add("Austria", "Vienna");
      countriesCapitals.Add("Switzerland", "Bern");
      countriesCapitals.Add("Australia", "Canberra");
      foreach (var item in countriesCapitals)
      {
         Console.WriteLine($"Country - {item.Key}, capital - {item.Value}");
      }

      countriesCapitals.Remove("Austria");
      foreach (var item in countriesCapitals.Keys)
      {
         Console.WriteLine($"Country - {item}");
      }

      // if(countriesCapitals.ContainsKey("Austria"))
      // Console.WriteLine(countriesCapitals["Austria"]);
   } 
}