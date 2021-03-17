using System;

namespace exercise_14
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Give me the truth!");
            string truth = Console.ReadLine();
            bool boolVal = Convert.ToBoolean(truth);
            Console.WriteLine(boolVal);

            Console.WriteLine("Give me the truth!");
            truth = Console.ReadLine();
            boolVal = Convert.ToBoolean(truth);
            Console.WriteLine(boolVal);



        }
  }
}
