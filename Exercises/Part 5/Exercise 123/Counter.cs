﻿using System;
namespace exercise_123
{
    public class Counter
    {
        public int value { get; set; }
        public Counter() :this(0)
        {
        }
        public Counter(int startValue)
        {
            this.value = startValue;
        }
        public void Increase()
        {
            this.Increase(1);
        }
        public void Decrease()
        {
            this.Decrease(1);
        }
        public void Increase(int increaseBy)
        {
            if(increaseBy > 0)
            {
                this.value += increaseBy;
            }
        }
        public void Decrease(int decreaseBy)
        {
            if (decreaseBy > 0)
            {
                this.value -= decreaseBy;
            }
        }
        public override string ToString()
        {
            return "Value is " + this.value;
            
        }
    }
}
