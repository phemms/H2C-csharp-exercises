using System;

namespace exercise_13
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Give a number!");
            string userInput = Console.ReadLine();
            double value = Convert.ToDouble(userInput);
            Console.WriteLine("You gave " + value);
            Console.WriteLine("Give a number!");
            userInput = Console.ReadLine();
            value = Convert.ToDouble(userInput);
            Console.WriteLine("You gave " + value);

        }
  }
}
