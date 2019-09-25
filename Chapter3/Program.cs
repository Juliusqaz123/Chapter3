using System;

namespace Chapter3
{
    public static class Program
    {
        public static void Main()
        {
#pragma warning disable
            while (false)
            {
                Console.WriteLine("Unreachable code");
            }
#pragma warning restore
            Console.ReadLine();
        }
    }
}
