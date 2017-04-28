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

            int? key = null;
            while ((key = StdIn.ReadInt()) != null)
            {
                if (BinarySearch.Rank(key.Value, whiteList) == -1)
                {
                    StdOut.PrintLine(key.Value);
                }
            }
        }
    }
}
