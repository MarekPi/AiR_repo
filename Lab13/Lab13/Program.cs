using System;
using System.Threading;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        /*
        public static void Main()
        {
            try
            {
                new Thread(Run).Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception!");
            }
        }
        static void Run() { throw null; } // Throws a NullReferenceException
        //Wywołanie powyższego kodu zwraca Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
        */
        /*
        public static void Main()
        {
            new Thread(Run).Start();
        }
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
        //Wywołanie kodu z Zadania 2 pozwala złapać wyjątek
        */
        /*
        static void Main()
        {
            Task.Factory.StartNew(Run);
        }
        static void Run()
        {
            Console.WriteLine("Hello !! The thread pool!");
        }
        */
        /*
        static void Main()
        {
            ThreadPool.QueueUserWorkItem(Run);
            ThreadPool.QueueUserWorkItem(Run, 123);
            Console.ReadLine();
        }
        static void Run(object data)
        {
            Console.WriteLine("Hello !! The thread pool! " + data);
        }
        //Wątki obsługiwane są zgodnie z kolejnością kolejki
        //Wywołanie kodu zwraca nam:
        //Hello !! The thread pool! 123
        //Hello !! The thread pool!
        */
        /*
        static void Main()
        {
            Func<string, int> method = Do;
            IAsyncResult cookie = method.BeginInvoke("test", null, null);
            // .. tutaj możemy równolegle wykonywać inne prace ...
            int result = method.EndInvoke(cookie);
            Console.WriteLine("String length is: " + result);
        }
        static int Do(string s) { return s.Length; }
        //na macOS nie mam możliwości wywołania powyższego kodu. Dostaję informację, że nie można obsłużyć go na tej platformie:
        //Unhandled exception.System.PlatformNotSupportedException: Operation is not supported on this platform.
        */
    }
}
