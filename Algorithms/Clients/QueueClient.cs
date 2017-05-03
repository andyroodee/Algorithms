using Algorithms.Collections;
using Algorithms.StdLib;

namespace Algorithms.Clients
{
    public class QueueClient
    {
        public static void Test(string[] args)
        {
            Queue<string> q = new Queue<string>();

            string item;
            while (StdIn.TryReadString(out item))
            {
                if (item != "-")
                {
                    q.Enqueue(item);
                }
                else if (!q.IsEmpty())
                {
                    StdOut.Print(q.Dequeue() + " ");
                }
            }

            StdOut.PrintLine("(" + q.Count + " left on queue)");
        }        
    }
}
