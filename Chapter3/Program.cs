using System;
using System.Diagnostics;

namespace Chapter3
{
    public class Program
    {
        public static void Main()
        {
            //-
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
