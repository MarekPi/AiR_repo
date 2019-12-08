using System;
namespace LAB7
{
    public class Point
    {
        int x, y;
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }
        public static bool operator true(Point p)
        {
            return (p.x != 0 | p.y != 0);
        }
        public static bool operator false(Point p)
        {
            return (p.x == 0 && p.y == 0);
        }
        public static bool operator ==(Point p1, Point p2)
        {
            return (p1.x == p2.x && p1.y == p2.y);
        }
        public static bool operator !=(Point p1, Point p2)
        {
            return (p1.x != p2.x || p1.y != p2.y);
        }
        public static bool operator <=(Point p1, Point p2)
        {
            return (p1.x <= p2.x && p1.y <= p2.y);
        }
        public static bool operator >=(Point p1, Point p2)
        {
            return (p1.x >= p2.x && p1.y >= p2.y);
        }
        public static Point operator ++(Point p)
        {
            Point p_new = new Point(p.x + 1, p.y + 1);
            return p_new;
        }
        public static Point operator --(Point p)
        {
            Point p_new = new Point(p.x - 1, p.y - 1);
            return p_new;
        }
        public static implicit operator Point(int i)
        {
            return new Point(i, 0);
        }
        public static explicit operator int(Point i)
        {
            return i.x + i.y;
        }
        public void print()
        {
            Console.WriteLine("x: {0}, y:{1}", this.x, this.y);
        }

    }
}
