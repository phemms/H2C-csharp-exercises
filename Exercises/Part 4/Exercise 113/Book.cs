using System;
namespace exercise_113
{
    public class Book
    {
        public string name { get; set; }
        public int page { get; set; }
        public int year { get; set; }

        public Book(string bkname, int pgnum, int yr)
        {
            this.name = bkname;
            this.page = pgnum;
            this.year = yr;
        }
        public override string ToString()
        {
            return this.name + ", " + this.page + " pages, " + this.year;
        }
    }
}
