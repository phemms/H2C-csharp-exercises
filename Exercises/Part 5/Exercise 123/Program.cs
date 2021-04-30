using System;

namespace exercise_123
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your code here.
      Counter counter = new Counter(45);
            counter.Increase(-1);
            Console.WriteLine(counter);
            counter.Decrease();
            Console.WriteLine(counter);

        }
  }
}
