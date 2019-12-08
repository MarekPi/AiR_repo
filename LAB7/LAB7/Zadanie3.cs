using System;
namespace LAB7
{
    delegate void F(int i, int j);
    public class Zadanie3
    {
        public void Zad3()
        {
            F F1 = new F(Dodawanie);
            F1(4, 2);
            F F2 = new F(Odejmowanie);
            F2(4, 2);
            F F3 = new F(Mnozenie);
            F3(4, 2);
            F F4 = new F(Dzielenie);
            F4(4, 2);
        }
        public void Dodawanie(int i, int j)
        {
            Console.WriteLine("Dodawanie {0}+{1}: {2}", i, j, i + j);
        }
        public void Odejmowanie(int i, int j)
        {
            Console.WriteLine("Odejmownie {0}-{1}: {2}", i, j, i - j);
        }
        public void Mnozenie(int i, int j)
        {
            Console.WriteLine("Mnozenie {0}*{1}: {2}", i, j, i * j);
        }
        public void Dzielenie(int i, int j)
        {
            Console.WriteLine("Dzielenie {0}/{1}: {2}", i, j, i / j);
        }

    }
}
