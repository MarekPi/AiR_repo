using System;
namespace Lab4
{
    public class Zadanie4
    {
        public Zadanie4()
        {
            int[] tab = new int[5];
            Console.WriteLine("Podaj 5 liczb, które chcesz dodać do tablicy:");
            for(int i = 0; i <5; i++)
            {
                tab[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Tablica przed zmianami:");
            foreach (int i in tab)
            {
                Console.Write("{0} ", i);
            }

            Array.Reverse(tab);
            Console.WriteLine("\nTablica po zmianach:");
            foreach (int i in tab)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
