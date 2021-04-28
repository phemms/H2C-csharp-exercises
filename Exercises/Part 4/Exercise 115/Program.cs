using System;

namespace exercise_115
{
  class Program
  {
    public static void Main(string[] args)
    {
            while (true)
            {
                string text = Console.ReadLine();
                if (text == "end")
                    break;

                int num = Convert.ToInt32(text);
                Console.WriteLine(num * num * num);
            }
    }
  }
}
