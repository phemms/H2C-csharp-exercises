using System;

namespace exercise_58
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Smallest(2, 7);
      Console.WriteLine("Smallest: " + answer);
    }

    public static int Smallest(int num1, int num2)
        {
            if (num1 < num2) return num1;
            else return num2;
        }
    
  }
}
