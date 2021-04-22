using System;
namespace exercise_104
{
    public class Multiplier
    {
        public int num { get; set; }
        public Multiplier(int number)
        {
            this.num = number;
        }
        public int Multiply(int number)
        {
            return this.num * number;
        }
    }
}
