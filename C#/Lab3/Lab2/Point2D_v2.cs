using System;
namespace Lab2
{
    public struct Point2D_v2
    {
        private double x, y;
        //private double x = 2, y = 2;
        // Powyższe jest błędne, ponieważ dla struktur nie można inicjować domyślnie wartości.


        //public Point2D_v2()
        //{
        //    this.x = 0;
        //    this.y = 0;
        //}
        // Struktury nie mogą zawierać konstruktorów bezparametrowych, więc powyższe jest błędne.

        public void Reset()
        {
            this.x = 0;
            this.y = 0;
        }

        public void IncX(int dx)
        {
            this.x += dx;
        }

        public void IncY(int dy)
        {
            this.y += dy;
        }

        public void Print2DPoint()
        {
            Console.WriteLine("x={0}; y={1}", this.x, this.y);
        }

        public double Dist(Point2D p)
        {
            double result = Math.Sqrt(Math.Pow((p.x - this.x), 2) + Math.Pow((p.y - this.y), 2));
            return result;
        }
    }
}
