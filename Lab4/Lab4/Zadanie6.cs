using System;
namespace Lab4
{
    public class Zadanie6
    {
        public Zadanie6()
        {
            int[,] tab1 ={ { 10, 1, 1, 1, 1 }, { 9, 2, 2, 2, 2}, { 8, 3, 3, 3, 3}, { 4, 4, 4, 4, 10 }, { 5, 5, 5, 5, 15} };
            int[,] tab2 ={ { 1, 1, 1, 1, 1 }, { 2, 2, 2, 2, 2}, { 3, 3, 3, 3, 3}, { 4, 4, 4, 4, 4 }, { 5, 5, 5, 5, 5} };
            int[,] tab3 = new int[5, 5];
            for(int i  = 0; i <5; i++)
            {
                for(int j=0; j < 5; j++)
                {
                    tab3[i, j] = tab1[i, j] + tab2[i, j];
                }
            }

            for(int i = 0; i<5;i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("{0} ", tab3[i, j]);
                }
                Console.Write("\n");
            }

            Console.WriteLine("\nLength: {0}", tab3.Length);
            Console.WriteLine("LongLength: {0}", tab3.LongLength);
            Console.WriteLine("Rank: {0}", tab3.Rank);

        }
    }
}
