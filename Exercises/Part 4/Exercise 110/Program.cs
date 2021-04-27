using System;
using System.Collections.Generic;

namespace exercise_110
{
  class Program
  {
    public static void Main(string[] args)
    {
            // IMPLEMENT YOUR CODE IN HERE!
            List<Item> item = new List<Item>();
            while (true)
            {
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                if (name == "") break;
                item.Add(new Item(name));
            }
            foreach(Item i in item)
            {
                Console.WriteLine(i);
            }

    }
  }
}




