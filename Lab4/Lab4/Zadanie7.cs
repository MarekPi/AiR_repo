using System;
namespace Lab4
{
    public class Zadanie7
    {
        public Zadanie7()
        {
            int[,] tab = { { 1, 0, -1 }, { 0, 0, 1 }, { -1, -1, 0 } };

            int det;
            det = tab[0, 0] * tab[1, 1] * tab[2, 2] + tab[0, 1] * tab[1, 2] * tab[2, 0] + tab[0, 2] * tab[1, 0] * tab[2, 1] - tab[0, 2] * tab[1, 1] * tab[2, 0] - tab[1, 2] * tab[2, 1] * tab[0, 0] - tab[2, 2] * tab[0, 1] * tab[1, 0];

            Console.WriteLine("Macierz:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0,3}", tab[i, j]);
                }
                Console.Write("\n");
            }
            Console.WriteLine("\nJej wyznacznik to: {0}", det);
        }
    }
}
