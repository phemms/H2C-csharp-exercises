using System;

namespace exercise_61
{
    class Program
    {
        public static void Main(String[] args)
        {
            //PrintSpaces(4);
            //PrintRightTriangle(7);
            ChristmasTree(10);
        }

        public static void PrintStars(int number)
        {
            Console.Write("*");
        }

        public static void PrintSpaces(int number)
        {
            Console.Write(" ");
        }

        public static void PrintRightTriangle(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for(int j = i; j < size; j++)
                {
                    PrintSpaces(i);
                }
                for(int j = 1; j<=i; j++)
                {
                    PrintStars(j);
                }
                Console.WriteLine();

            }

        }

        public static void ChristmasTree(int height)
        {
            int star = 1;
            int max = (height * 2) - 1;
            int centre = max / 2 + 1;
            int h = height;
            for(int i = 0; i<=height; i++)
            {
                for(int j = 0; j < h; j++)
                {
                    PrintSpaces(j);
                }
                for(int k = 0; k<star; k++)
                {
                    PrintStars(k);
                    Console.Write(" ");
                }
                Console.WriteLine();
                star++;
                h--;
                
            }
            for(int i = 0; i<1; i++)
            {
                for(int j = 1; j <= centre; j++)
                {
                    if (j == centre)
                    {
                        PrintStars(j);
                        PrintStars(j);
                        PrintStars(j);
                    }

                    else PrintSpaces(j);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 1; i++)
            {
                for (int j = 1; j <= centre; j++)
                {
                    if (j == centre)
                    {
                        PrintStars(j);
                        PrintStars(j);
                        PrintStars(j);
                    }

                    else PrintSpaces(j);
                }
            }
        }
}
}


