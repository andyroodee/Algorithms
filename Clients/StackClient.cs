using Algorithms.Collections;
using Algorithms.StdLib;
using System;

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

        public static void Reverse(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int result;
            while (StdIn.TryReadInt(out result))
            {
                stack.Push(result);
            }

            foreach (int i in stack)
            {
                StdOut.PrintLine(i);
            }
        }

        // Implements Dijkstra's Two-Stack Algorithm for Expression Evaluation.
        public static void Evaluate(string[] args)
        {
            Stack<string> ops = new Stack<string>();
            Stack<double> vals = new Stack<double>();
            string s;
            while (StdIn.TryReadString(out s))
            {
                switch (s)
                {
                    case "(": break;
                    case "+": ops.Push(s); break;
                    case "-": ops.Push(s); break;
                    case "*": ops.Push(s); break;
                    case "/": ops.Push(s); break;
                    case "sqrt": ops.Push(s); break;
                    case ")":
                        {
                            string op = ops.Pop();
                            double v = vals.Pop();
                            switch (op)
                            {
                                case "+": v = vals.Pop() + v; break;
                                case "-": v = vals.Pop() - v; break;
                                case "*": v = vals.Pop() * v; break;
                                case "/": v = vals.Pop() / v; break;
                                case "sqrt": v = Math.Sqrt(v); ; break;
                            }
                            vals.Push(v);
                        }
                        break;
                    default: vals.Push(double.Parse(s)); break;
                }
            }
            StdOut.PrintLine(vals.Pop());
        }
    }
}
