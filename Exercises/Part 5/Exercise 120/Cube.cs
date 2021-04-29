using System;
namespace exercise_120
{
    public class Cube
    {
        private int length;
        public Cube(int edgeLength)
        {
            this.length = edgeLength;
        }
        public int Volume()
        {
            return this.length * this.length * this.length;
        }
        public override string ToString()
        {
            return "The length of the edge is " + this.length + " the Volume is " + this.Volume();
        }
    }
}
