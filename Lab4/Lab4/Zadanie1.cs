using System;
namespace Lab4
{
    public class Zadanie1
    {
        void Fun1(in int i)
        {
            //i = i + 1;
        }

        void Fun2(out int i)
        {
            i = 1;
            i = i + 2;
        }

        void Fun3(ref int i)
        {
            i = i + 3;
        }

        void Fun4(int i)
        {
            i = i + 4;
        }

        void Fun5(in int i)
        { 
        }
        //void Fun5(out int i) // nie można definiować przeciążonych metod różniących się jedynie modyfikatorem in / out
        //{
        //}

        public void Zadanie1_Main()
        {
            int i;
            i = 1;
            //Fun1(i); //wywołanie Fun1 z parametrem i skutkuje błędem kompilacji: Error CS8331: Cannot assign to variable 'in int' because it is a readonly variable (CS8331) (Lab4)
            //Console.WriteLine("Wartosc i po wywolaniu funkcji Fun1: {0}", i);

            i = 2;
            Fun2(out i); //wywolanie Fun2 z parametrem i skutkuje błędem kompilacji: Error CS0269: Use of unassigned out parameter 'i' (CS0269) (Lab4)
            //konieczne było dodanie linii i=1 w funkcji.
            Console.WriteLine("Wartosc i po wywolaniu funkcji Fun2: {0}", i);

            i = 3;
            Fun3(ref i);
            Console.WriteLine("Wartosc i po wywolaniu funkcji Fun3: {0}", i);

            i = 4;
            Fun4(i);
            Console.WriteLine("Wartosc i po wywolaniu funkcji Fun4: {0}", i);

            short sh;
            sh = 1;
            //Fun2(out sh);
            //Fun3(ref sh); // nie można przekonwertować short sh na int

        }
    }
}
