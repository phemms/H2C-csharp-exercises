using System;

namespace exercise_32
{
  class Program
  {
    public static void Main(string[] args)
    {
            string friend = "Mellon";
            Console.WriteLine("Speak, friend and enter!");
            string userInput = Console.ReadLine();
            if (userInput == friend)
            {
                Console.WriteLine("Welcome, friend");
            }
            else
            {
                Console.WriteLine("They've got a cave troll!");
            }
    }
  }
}
