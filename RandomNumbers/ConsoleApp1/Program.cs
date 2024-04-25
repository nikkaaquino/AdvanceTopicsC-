// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

Random random = new Random();

/**
for (int i = 0; i < 10; i++)
{
   //Console.WriteLine(random.Next(11)); //max value
   Console.WriteLine(random.Next(5, 11)); // min and max value
}
**/

// Use Random Well
/**
for (int i = 0; i < 10; i++){
    SimpleMethod(random);
}**/

//Generating a double
/**for (int i = 0; i < 10; i++)
{
    //Console.WriteLine(random.NextDouble());
    Console.WriteLine(random.NextDouble()*10); // 0 and less than 10
}**/

//Sorting: shuffle a small list
/**
List<PersonModel> people = new List<PersonModel>{
    new PersonModel { FirstName = "Nikka"},
    new PersonModel  { FirstName = "Tim"},
    new PersonModel { FirstName = "Sue"},
    new PersonModel  { FirstName = "Mary"},
    new PersonModel { FirstName = "Jane"},
    new PersonModel  { FirstName = "Nancy"},
    new PersonModel { FirstName = "Kenvi"},
    new PersonModel  { FirstName = "Paul"}
};

//var sortedPeople = people.OrderBy(x => x.FirstName); //order alphabetically
var sortedPeople = people.OrderBy(x => random.Next());  //shuffle

foreach(var p in sortedPeople){
    Console.WriteLine(p.FirstName);
}**/

//Sorting: shuffle a large list (Fisher-Yates shuffle)
// https://stackoverflow.com/questions/273313/randomize-a-listt/1262619#1262619

var numbers = new List<int>(Enumerable.Range(1, 75));
      numbers.Shuffle();
      Console.WriteLine("The winning numbers are: {0}", string.Join(",  ", numbers.GetRange(0, 5)));


Console.ReadLine();

static void SimpleMethod(Random random){
    Console.WriteLine(random.Next());
}

public class PersonModel
{
    public string FirstName { get; set;}
}


 public static class ThreadSafeRandom
  {
      [ThreadStatic] private static Random Local;

      public static Random ThisThreadsRandom
      {
          get { return Local ?? (Local = new Random(unchecked(Environment.TickCount * 31 + Thread.CurrentThread.ManagedThreadId))); }
      }
  }

  static class MyExtensions
  {
    public static void Shuffle<T>(this IList<T> list)
    {
      int n = list.Count;
      while (n > 1)
      {
        n--;
        int k = ThreadSafeRandom.ThisThreadsRandom.Next(n + 1);
        T value = list[k];
        list[k] = list[n];
        list[n] = value;
      }
    }
  }

