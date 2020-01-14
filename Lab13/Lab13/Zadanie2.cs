using System;
namespace Lab13
{
    public class Zadanie2
    {
        public Zadanie2()
        {
            static void Run()
            {
                try
                {
                    // ...
                    throw null;
                    // ...
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception!");
                }
            }
        }
    }
}
