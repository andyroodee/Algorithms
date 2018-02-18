using System;

namespace Algorithms.StdLib
{
    public static class StdOut
    {
        public static void PrintLine<T>(T val)
        {
            Console.WriteLine(val);
        }

        public static void Print<T>(T val)
        {
            Console.Write(val);
        }

        public static void PrintFormat(string formatString, params object[] args)
        {
            Console.Write(formatString, args);
        }
    }
}
