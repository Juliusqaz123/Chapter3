using System;
using System.Security;
using System.Security.Permissions;

namespace Chapter3
{
    static class Program
    {
        static void Main(string[] args)
        {
            using (SecureString ss = new SecureString())
            {
                Console.Write("Please enter password: ");
                while (true)
                {
                    ConsoleKeyInfo cki = Console.ReadKey(true);
                    if (cki.Key == ConsoleKey.Enter) break;

                    ss.AppendChar(cki.KeyChar);
                    Console.Write("*");
                }
                ss.MakeReadOnly();
            }

            Console.ReadLine();
        }
    }
}
