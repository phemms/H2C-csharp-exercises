using System;
using System.Collections.Generic;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    {
            int big = 0;
            while (true)
            {
                string phrase = Console.ReadLine();
                if (phrase == "") break;
                string[] words = phrase.Split(',');
                int age = Convert.ToInt32(words[1]);
                if (age > big) big = age;
            }
            Console.WriteLine("Age of oldest: " + big);

        }
  }
}



