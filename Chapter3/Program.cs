#define MySymbol

using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

namespace Chapter3
{
    public  class Program
    {
        public static void Main()
        {
            Debug.WriteLine("Starting application");
            Debug.Indent();
            int i = 1 + 2;
            Debug.Assert(i == 3);
            Debug.WriteLine(i > 0, "is greater than 0");
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

        public void UseCustomSymbol()
        {
#if MySymbol
            Console.WriteLine("Custom symbol is defined");
#endif
        }

        public Assembly LoadAssembly<T>()
        {
#if !WINRT
            Assembly assembly = typeof(T).Assembly;
#else
            Assembly assembly = typeof(T).GetTypeInfo().Assembly;
#endif
            return assembly;
        }

        public void SomeMethod()
        {
#if DEBUG
            Log("Step1");
#endif
        }

        [Conditional("DEBUG")]
        private static void Log(string message)
        {
            Console.WriteLine("message");
        }

    }
}
