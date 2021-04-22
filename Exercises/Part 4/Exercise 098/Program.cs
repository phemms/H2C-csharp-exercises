using System;

namespace exercise_98
{
  class Program
  {
    public static void Main(string[] args)
    {
            // Create Product.cs and follow the instructions.
            // You can test your class with this.
            Product product = new Product("Banana", 1.1, 13);
            product.PrintProduct();
      

    }
        public class Product
        {
            private double price;
            private int quantity;
            private string name;
            public Product(string name, double price, int quantity)
            {
                this.price = price;
                this.quantity = quantity;
                this.name = name;
            }
            public void PrintProduct()
            {
                Console.WriteLine(this.name +": price " + this.price + ": " + this.quantity + " pcs");
            }
        }
  }
}



