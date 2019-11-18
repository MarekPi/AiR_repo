using System;
namespace Lab5
{
    public class Zadanie1
    {
        public Zadanie1()
        {
        }
        public void trojkat1()
        {
            Console.WriteLine("Podaj wysokosc trojkata:");
            int a = int.Parse(Console.ReadLine());
            int i = 1;
            Console.WriteLine("\nPetla for:");
            string s = "";
            for(i = 1; i <= a; i++)
            {
                s += i.ToString();
                Console.WriteLine(s);
            }
            i = 1;
            s = "";
            Console.WriteLine("\nPetla while:");
            while(i<=a)
            {
                s += i.ToString();
                Console.WriteLine(s);
                i += 1;
            }

            i = 1;
            s = "";
            Console.WriteLine("\nPetla do-while:");
            do
            {
                s += i.ToString();
                Console.WriteLine(s);
                i += 1;
            }
            while (i <= a);
        }

        public void trojkat2()
        {
            Console.WriteLine("Podaj wysokosc trojkata:");
            int a = int.Parse(Console.ReadLine());
            int i = 1;
            string s = "";
            Console.WriteLine("\nPetla for:");

            for(i = 1; i<=a; i++)
            {

                s = "";
                for (int j = 1; j<=i; j++)
                {
               
                    s += i.ToString();
                }
                Console.WriteLine(s);

            }

            i = 1;
            s = "";
            Console.WriteLine("\nPetla while:");
            while (i <= a)
            {
                s = "";
                for (int j = 1; j <= i; j++)
                {

                    s += i.ToString();
                }
                Console.WriteLine(s);
                i += 1;
            }

            i = 1;
            s = "";
            Console.WriteLine("\nPetla do-while:");
            do
            {
                s = "";
                for (int j = 1; j <= i; j++)
                {

                    s += i.ToString();
                }
                Console.WriteLine(s);
                i += 1;
            }
            while (i<=a);

        }
    }
}
