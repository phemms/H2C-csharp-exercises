using System;
using System.Collections.Generic;

namespace exercise_112
{
  class Program
  {
    public static void Main(string[] args)
    {
            // IMPLEMENT YOUR CODE IN HERE!
            List<TelevisionProgram> list = new List<TelevisionProgram>();
            while (true)
            {
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                if (name == "")
                {
                    break;
                }
                Console.WriteLine("Duration: ");
                int dur = Convert.ToInt32(Console.ReadLine());


                list.Add(new TelevisionProgram(name, dur));
            }
            Console.WriteLine();
            Console.WriteLine("Program's maximum duration? ");
            int d = Convert.ToInt32(Console.ReadLine());
            foreach (TelevisionProgram t in list)
            {
                if (t.duration <= d) Console.WriteLine(t);
            }


        }
  }
}




