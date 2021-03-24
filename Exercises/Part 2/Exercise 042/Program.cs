using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

            int firstNum = Convert.ToInt32(Console.ReadLine());
            int secondNum = Convert.ToInt32(Console.ReadLine());
            int sum = firstNum + secondNum;
            double sqrRoot = Math.Sqrt(sum);
            Console.WriteLine(sqrRoot);

        }
  }
}
