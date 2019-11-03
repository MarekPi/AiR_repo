using System;
namespace Lab2
{
    public struct Coords
    {
        public int x, y;

        public Coords(int p1, int p2)
        {
            x = p1;
            y = p2;
        }

        public void Print()
        {
            Console.WriteLine("Klasa Coords, wartosci:\nx={0}, y={1}\n", x, y);
        }

    }
}
