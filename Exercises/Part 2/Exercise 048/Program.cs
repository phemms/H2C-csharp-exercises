using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {
            int sum = 0; int count = 0;int even = 0;int odd = 0;
            Console.WriteLine("Give numbers: ");
            int num = Convert.ToInt32(Console.ReadLine());
            while(num != -1)
            {
                count += 1;
                sum += num;
                if (num % 2 == 0) even++;
                else odd++;
                num = Convert.ToInt32(Console.ReadLine());
                
            }
            double average = (double)sum / count;
            Console.WriteLine("Thx! Bye!");
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Numbers: " + count);
            Console.WriteLine("Average: " + average);
            Console.WriteLine("Even: " + even);
            Console.WriteLine("Odd: " + odd);

        }
  }
}
