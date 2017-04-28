using System;
using System.Linq;
using Algorithms.StdLib;
using Algorithms.Searching;

namespace Algorithms.Clients
{
    class BinarySearchClient
    {
        public static void WhiteList(string[] args)
        {
            int[] whiteList = In.ReadAllIntsFromFile(args[0]).ToArray();

            Array.Sort(whiteList);

            int key;
            while (StdIn.TryReadInt(out key))
            {
                if (BinarySearch.Rank(key, whiteList) == -1)
                {
                    StdOut.PrintLine(key);
                }
            }
        }
    }
}
