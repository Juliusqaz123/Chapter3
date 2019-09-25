using System;

namespace Chapter3
{
    public class Program
    {
        public static void Main()
        {
#pragma warning disable 0162, 0168
            int i;
#pragma warning restore 0162
            while (false)
            {
                Console.WriteLine("Unreachable code");
            }
#pragma warning restore
            Console.ReadLine();
        }

        public void SomeMethod()
        {
#if DEBUG
            Log("Step1");
#endif
        }

        private static void Log(string message)
        {
            Console.WriteLine("message");
        }
    }
}
