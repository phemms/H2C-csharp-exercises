using System;
namespace exercise_102
{
    public class Gauge
    {
        public int value { get; set; }
        public Gauge()
        {
            this.value = 0;
        }
        public void Increase()
        {
            this.value += 1;
            if (this.value > 5) this.value = 5;
        }
        public void Decrease()
        {
            this.value -= 1;
            if (this.value < 0) this.value = 0;
        }
        public bool Full()
        {
            if (this.value == 5) return true;
            else return false;
        }
    }
}
