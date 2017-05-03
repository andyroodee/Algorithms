using System;
using System.Collections.Generic;

namespace Algorithms.Searching
{
    public class BinarySearch
    {
        public static int Rank<T>(T key, IList<T> data)
            where T : IComparable<T>
        {
            int low = 0;
            int high = data.Count - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                int compareResult = key.CompareTo(data[mid]);
                if (compareResult < 0)
                {
                    high = mid - 1;
                }
                else if (compareResult > 0)
                {
                    low = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}
