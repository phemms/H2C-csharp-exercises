using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

            int secsDay = 86400;
            Console.WriteLine("How many days? ");
            string days = Console.ReadLine();
            int day = Convert.ToInt32(days);
            Console.WriteLine(secsDay*day);

    }
  }
}
