using System;
namespace Lab5
{
    public class Zadanie2
    {
        public Zadanie2()
        {
            Int32 i = 23;
            object o = i;
            i = 123;
            Console.WriteLine(i + ", " + (Int32)o);
            long j = (long)o;
            //Console.WriteLine(i + ", " + (Int32)o + ", " + j);
        }
    }
}
