﻿using System;

namespace exercise_59
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Greatest(2, 7, 10);
      Console.WriteLine("Greatest: " + answer);
    }

    public static int Greatest(int num1, int num2, int num3)
        {
            if (num1 > num2)
                if (num1 > num3) return num1;
                else return num3;
            else if (num2 > num3) return num2;
            else return num3;
        }

  }
}
