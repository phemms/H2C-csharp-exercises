using System;
using System.Collections.Generic;

namespace exercise_78
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT CHANGE THE FOLLOWING CODE!
      int[] array = new int[5];
      array[0] = 1;
      array[1] = 3;
      array[2] = 5;
      array[3] = 7;
      array[4] = 9;

      int index = 0;
      while (index < array.Length)
      {
        Console.WriteLine(array[index]);
        index++;
      }
      Console.WriteLine("");

      int ind1 = Convert.ToInt32(Console.ReadLine());
      int ind2 = Convert.ToInt32(Console.ReadLine());
            int num1 = array[ind1];
            int num2 = array[ind2];
            array[ind1] = num2;
            array[ind2] = num1;


      // DO NOT CHANGE THE FOLLOWING CODE!
      Console.WriteLine("");
      index = 0;
      while (index < array.Length)
      {
        Console.WriteLine(array[index]);
        index++;
      }
    }

  }
}


