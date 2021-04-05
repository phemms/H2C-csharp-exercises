using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
            PrintUntilNumber(3);


        }

    public static void PrintUntilNumber(int num)
        {
            int i = 1;
            while (i <= num)
            {
                Console.WriteLine(i);
                i++;
            }
        }

    }
}
