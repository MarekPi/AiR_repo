using System;
namespace Lab5
{
    public class Zadanie3
    {
        public Zadanie3()
        {
            int? a = null;
            int? b = 10;

            Console.WriteLine(a.GetValueOrDefault(999));
            Console.WriteLine(b.GetValueOrDefault(999));
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
