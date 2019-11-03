using System;
namespace Lab2
{
    public class Point
    {
        public int x, y;

        public Point(int p1, int p2)
        {
            x = p1;
            y = p2;
        }

        public void Print()
        {
            Console.WriteLine("Klasa Point, wartosci:\nx={0}, y={1}\n", x, y);
        }
    }
}
