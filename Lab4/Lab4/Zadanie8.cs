using System;
namespace Lab4
{
    public class Zadanie8
    {
        public Zadanie8()
        {
            int[][] tab1 = new int[5][];
            tab1[0] = new int[] { 1, 2, 3 };
            tab1[1] = new int[] { 4, 5, 6, 7, 8, 9 };
            tab1[2] = new int[] { 10, 11, 12, 13 };
            tab1[3] = new int[] { 14, 15, 16, 17, 18 };
            tab1[4] = new int[] { 19, 20, 21 };

            Console.WriteLine("Sposob 1:\n");
            foreach (int[] row in tab1)
            {
                Console.WriteLine(String.Join(" ", row));
            }

            int[][] tab2 = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6, 7, 8, 9 },
                new int[] { 10, 11, 12, 13 },
                new int[] { 14, 15, 16, 17, 18},
                new int[] { 19, 20, 21}
            };

            Console.WriteLine("\nSposob 2:\n");
            foreach (int[] row in tab2)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }
    }
}
