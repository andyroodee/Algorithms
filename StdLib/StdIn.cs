using System;
using System.Text;

namespace Algorithms.StdLib
{
    public static class StdIn
    {
        public static int? ReadInt()
        {
            StringBuilder sb = new StringBuilder();
            int val;
            while ((val = Console.Read()) != -1)
            {
                char c = (char)val;
                if (char.IsDigit(c))
                {
                    sb.Append((char)val);
                }
                else if (sb.Length > 0)
                {
                    return int.Parse(sb.ToString());
                }
            }

            if (sb.Length > 0)
            {
                return int.Parse(sb.ToString());
            }

            return null;
        }
    }
}
