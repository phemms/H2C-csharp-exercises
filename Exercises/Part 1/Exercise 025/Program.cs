using System;

namespace exercise_25
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Give a number:");
            string userInput = Console.ReadLine();
            int year = Convert.ToInt32(userInput);
            if (year == 1984)
            {
                Console.WriteLine("Orwell");
            }

        }
  }
}
