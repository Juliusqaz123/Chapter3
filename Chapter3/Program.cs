using System;
using System.Security;
using System.Security.Permissions;

namespace Chapter3
{
    static class Program
    {
        static void Main(string[] args)
        {
            FileIOPermission f = new FileIOPermission(PermissionState.None)
            {
                AllLocalFiles = FileIOPermissionAccess.Read
            };
            try
            {
                f.Demand();
            }
            catch (SecurityException s)
            {
                Console.WriteLine(s.Message);
            }

            Console.ReadLine();
        }
    }
}
