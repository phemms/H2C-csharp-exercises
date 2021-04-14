using System;
using System.Collections.Generic;

namespace exercise_70
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
      }
      int g = list[0];
      for(int i = 0; i < list.Count; i++)
            {
                int num = list[i];
                if (num > g) g = num;
            }
            Console.WriteLine("The grEatest number: " + g);
    }
  }
}
