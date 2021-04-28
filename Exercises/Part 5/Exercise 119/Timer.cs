using System;
namespace exercise_119
{
    public class Timer
    {
        private ClockHand hundreds;
        private ClockHand seconds;
        public Timer()
        {
            this.hundreds = new ClockHand(100);
            this.seconds = new ClockHand(60);
            
        }
        public void Advance()
        {
            this.hundreds.Advance();
            if (this.hundreds.value == 0)
                this.seconds.Advance();
        }
        public override string ToString()
        {
            return seconds + ":" + hundreds;
        }
    }
}
