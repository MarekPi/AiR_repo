using System;
namespace Lab4
{
    public class Zadanie5
    {
        public Zadanie5()
        {
            int[] tab = { 1, 2, 3, 5, 5 };

            Console.WriteLine("Podaj liczbę, której wystąpienia chcesz zliczyc:");
            int a = int.Parse(Console.ReadLine());
            int counter = 0;
            foreach (int i in tab)
            {
                if (i == a)
                {
                    counter++;
                }
            }
            Console.WriteLine("Liczba {0} pojawia się w tablicy {1} razy", a, counter);
        }
    }
}
