using System;
namespace Lab4
{
    public class Zadanie3
    {
        public Zadanie3()
        {
            Console.WriteLine("Podaj liczbe do wstawienia do tablicy:");
            int i = int.Parse(Console.ReadLine());

            int[] tab = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Postać tablicy przed zmianami:");
            foreach (int j in tab)
            {
                Console.Write("{0} ", j);
            }
            Array.Resize(ref tab, tab.Length + 1);

            for (int k = tab.Length - 2; k >= 0; k--)
            {
                tab[k + 1] = tab[k];
            }

            tab[tab.GetLowerBound(0)] = i;

            Console.WriteLine("\nPostać tablicy po zmianach:");
            foreach (int j in tab)
            {
                Console.Write("{0} ", j);
            }
        }
    }
}
