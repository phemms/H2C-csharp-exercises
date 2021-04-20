using System;
using System.Collections.Generic;

namespace exercise_89
{
  class Program
  {
    public static void Main(string[] args)
    {
            while (true)
            {
                string phrase = Console.ReadLine();
                if (phrase == "") break;
                string[] words = phrase.Split(' ');
                Console.WriteLine(words[words.Length - 1]);
            }

        }
  }
}



