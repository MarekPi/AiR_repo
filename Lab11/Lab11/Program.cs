using System;
using System.Collections.Generic;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            List<string> list = new List<string> { "*", "!", "@", "#", "$", "^" };
            int MAX = 20;
            for (int i = 0; i < MAX; i++)
            {
                Console.SetCursorPosition(MAX - i, 0 + i);
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    if (i == 0)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        int index = random.Next(list.Count);
                        Console.Write(list[index]);
                    }

                }
                Console.WriteLine();

            }
            for (int i = 0; i < 5; i++)
            {
                switch (i)
                {
                    case 1:
                        drawGift(1, 0, 2, MAX);
                        drawGift(3, -2, 1, MAX);
                        drawGift(6, 0, 1, MAX);
                        drawGift(7, 2, 2, MAX);

                        break;
                    default:
                        break;
                }

                Console.SetCursorPosition(MAX - 1, MAX + i);
                Console.WriteLine("| |");
            }

        }
        public static void drawGift(int a, int b, int yy, int MAX)
        {
            int tmp = (int)((a*MAX / 4)+b);
            Console.SetCursorPosition(tmp, MAX + yy);
            Console.Write("\\");
            Console.SetCursorPosition(tmp + 1, MAX + yy);
            Console.Write("/");
            Console.SetCursorPosition(tmp - 1, MAX + yy+1);
            Console.Write("|");
            Console.SetCursorPosition(tmp + 2, MAX + yy+1);
            Console.Write("|");
            Console.SetCursorPosition(tmp, MAX + yy+1);
            Console.Write("__");
        }
    }
}