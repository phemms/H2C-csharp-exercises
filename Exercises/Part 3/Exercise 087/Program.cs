using System;
using System.Collections.Generic;

namespace exercise_87
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
                foreach (string t in words)
                {
                    if(t.Contains("av"))
                    Console.WriteLine(t);
                }
            }
        }

  }

}

