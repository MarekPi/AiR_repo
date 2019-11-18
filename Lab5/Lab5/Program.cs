using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadanie1 z1 = new Zadanie1();
            //z1.trojkat1();
            //z1.trojkat2();

            //Zadanie2 z2 = new Zadanie2();
            //wypisane jest 123, 23 ponieważ zmieniamy wartość zmiennej i, natomiast nie odnosi się to do wcześniej utworzonego obiektu
            //po konwersji (long)o otrzymujemy blad kompilacji: Unable to cast object of type 'System.Int32' to type 'System.Int64'.

            //Zadanie3 z3 = new Zadanie3();
            //Zadanie4 z4 = new Zadanie4();

            //Zadanie7:
            int[] tab = { 1, 2, 3, 4 };
            int[] tab2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Matrix m = new Matrix(2,2,tab);
            Matrix m2 = new Matrix(3, 3, tab2);
            m.PrintMatrix();
            m2.PrintMatrix();
        }
    }
}
