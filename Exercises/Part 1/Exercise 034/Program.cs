﻿using System;

namespace exercise_34
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true)
            {
                Console.WriteLine("Do you want to continue?");
                string userInput = Console.ReadLine();
                if (userInput == "no")
                {
                    break;
                }
            }

    }
  }
}
