using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("How old are you?");
            string userInput = Console.ReadLine();
            int num = Convert.ToInt32(userInput);
            if (num > 0 && num < 18)
            {
                Console.WriteLine("You're under age!");
            }

            else
            {
                Console.WriteLine("You're an adult!");
            }

        }
  }
}
