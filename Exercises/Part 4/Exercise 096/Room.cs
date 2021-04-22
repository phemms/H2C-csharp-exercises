using System;
namespace Exercise_096
{
    public class Room
    {
        private string code;
        private int seat;
        public Room(string classCode, int numberOfSeats)
        {
            this.code = classCode;
            this.seat = numberOfSeats;

        }
    }
    
}
