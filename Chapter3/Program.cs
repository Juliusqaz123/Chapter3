using System;
using System.Reflection;
using System.Threading;

namespace Chapter3
{
    public  class Program
    {
        public static void Main()
        {

        }

        public Assembly LoadAssembly<T>()
        {
#if !WINRT
            Assembly assembly = typeof(T).Assembly;
#else
            Assembly asembly = typeof(T).GetTypeInfo().Assembly;
#endif
            return assembly;
        }
    }
}
