using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
            int small = 2020;
            int size = 0;
            string name = "w";

            while (true)
            {
                string phrase = Console.ReadLine();
                if (phrase == "") break;
                string[] words = phrase.Split(',');
                int year = Convert.ToInt32(words[1]);
                int length = words[0].Length;
                if (year < small)
                {
                    small = year;
                }
                if(length > size)
                {
                    size = length;
                    name = words[0];
                }
            }
            Console.WriteLine("Longest name: " + name);
            Console.WriteLine("Highest age: " + (2020 - small));
        }
  }
}



