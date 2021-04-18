using System;
using System.Collections.Generic;

namespace exercise_74
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
      }
      Console.WriteLine("Search for?");
      string s = Console.ReadLine();
            if (list.Contains(s))
                { Console.WriteLine(s + " was found!"); }
            else Console.WriteLine(s + " was not found!");     
            
        }
  }
}

