using System;
using System.Collections.Generic;

namespace exercise_72
{
  class Program
  {
    public static void Main(string[] args)
    {
            List<int> list = new List<int>();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 9999)
                {
                    break;
                }
                list.Add(input);
            }
            //int c = 0;
            int s = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                int num = list[i];
                if (s > num) s = num;
                {

                }
            }
            Console.WriteLine("smallest number: " + s);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == s)
                {
                    Console.WriteLine("Found at index " + i);
                }
            }

        }
    }
}
