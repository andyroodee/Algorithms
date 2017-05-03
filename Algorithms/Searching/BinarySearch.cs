namespace Algorithms.Searching
{
    public class BinarySearch
    {
        public static int Rank(int key, int[] a)
        {
            int low = 0;
            int high = a.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (key < a[mid])
                {
                    high = mid - 1;
                }
                else if (key > a[mid])
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
