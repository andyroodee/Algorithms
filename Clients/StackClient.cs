using Algorithms.Collections;
using Algorithms.StdLib;

namespace Algorithms.Clients
{
    public class StackClient
    {
        public static void Test(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            string item;
            while (StdIn.TryReadString(out item))
            {
                if (item != "-")
                {
                    stack.Push(item);
                }
                else if (!stack.IsEmpty())
                {
                    StdOut.Print(stack.Pop() + " ");
                }
            }

            StdOut.PrintLine("(" + stack.Count + " left on stack)");
        }
    }
}
