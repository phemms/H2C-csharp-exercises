using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Give the first string: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("Give the second string: ");
            string secUserInput = Console.ReadLine();
            if(userInput == secUserInput)
            {
                Console.WriteLine("Echo!");
            }
            else
            {
                Console.WriteLine("Nope!");
            }

    }
  }
}
