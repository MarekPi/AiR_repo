using System;
using System.Threading;

namespace Lab12
{
    class Program
    {
        /*
        class ThreadExample
        {
            static void Main()
            {
                Thread t = new Thread(Write1); //Uruchom inny wątek
                t.Start();
                // Główny wątek.
                for (int i = 0; i < 1000; i++) Console.Write("0");
            }
            //Inny wątek
            static void Write1()
            {
                for (int i = 0; i < 1000; i++) Console.Write("1");
            }
        }
        */
        /*
        static void Main()
        {
            new Thread(Run).Start(); // Uruchom Run w innym wątku
            Run(); // Uruchom Run w głownym wątku
        }
        static void Run()
        {
            // Deklaracja i użycie zmiennej lokalnej - 'cycles'
            for (int cycles = 0; cycles < 5; cycles++) Console.Write('x');
        }
        // x został wypisany 10 razy. Wynika to z tego, że metoda Run wywoływana jest w dwa razy, w osobnych wątkach.
        */
        /*
        class ThreadExample
        {
            static bool done; // Pole statyczne
            static void Main()
            {
                new Thread(Run).Start();
                Run();
            }
            static void Run()
            {
                if (!done) { done = true; Console.WriteLine("Done"); }
            }
        }
        // Done wypisuje się jeden raz
        */
        class ThreadExample
        {
            static bool done; // Pole statyczne
            static void Main()
            {
                new Thread(Run).Start();
                Run();
            }
            static void Run()
            {
                if (!done) { Console.WriteLine("Done"); done = true; }
            }
        }
        // Done wypisuje się dwa razy


    }
}
