using System;

namespace exercise_26
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give your age:");
            string userInput = Console.ReadLine();
            int year = Convert.ToInt32(userInput);
            if (year < 1900)
            {
                Console.WriteLine("Your're old");

            }
        }
    }
}