using System;
using System.Collections.Generic;

namespace exercise_91
{
  class Program
  {
    public static void Main(string[] args)
    {
            int big = 0;
            string name = "w";
            while (true)
            {
                string phrase = Console.ReadLine();
                if (phrase == "") break;
                string[] words = phrase.Split(',');
                int age = Convert.ToInt32(words[1]);
                if (age > big)
                {
                    big = age;
                    name = words[0];
                }
            }
            Console.WriteLine("Name of oldest: " + name);
        }
  }
}



