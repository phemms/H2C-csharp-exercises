using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
            int count = 0;

            while (true)
            {
                Console.WriteLine("Give a number:");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num == 0)
                {
                    break;
                }
                else if (num > 0)
                {
                    continue;
                }
                else
                {
                    count +=1;
                }
            }
            Console.WriteLine("Total amount of negative numbers: " + count);


        }
    }
}
