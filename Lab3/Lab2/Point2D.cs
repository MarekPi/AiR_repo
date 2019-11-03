using System;
namespace Lab2
{
    public struct Point2D
    {
        public double x, y;

        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

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
            double result = Math.Sqrt(Math.Pow((p.x - this.x),2) + Math.Pow((p.y - this.y),2));
            return result;
        }
    }
}
