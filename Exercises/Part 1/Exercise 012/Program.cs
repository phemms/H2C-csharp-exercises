﻿using System;

namespace exercise_12
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.WriteLine("Give a number!");
            string userInput = Console.ReadLine();
            int value = Convert.ToInt32(userInput);
            Console.WriteLine("You gave " + value);
            Console.WriteLine("Give a number!");
            userInput = Console.ReadLine();
            value = Convert.ToInt32(userInput);
            Console.WriteLine("You gave " + value);

    }
  }
}
