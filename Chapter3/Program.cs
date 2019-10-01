using System;
using System.Threading;

namespace Chapter3
{
    public  class Program
    {
        public static void Main()
        {
            Timer t = new Timer(TimerCallback, null, 0, 2000);
            Console.ReadLine();
        }

        private static void TimerCallback(Object o)
        {
            Console.WriteLine("In TimerCallBack: " + DateTime.Now);
            GC.Collect();
        }

        public void DebugDirective()
        {
#if DEBUG
            Console.WriteLine("Debug mode");
#else
            Console.WriteLine("Not debug");
#endif
        }
    }
}
