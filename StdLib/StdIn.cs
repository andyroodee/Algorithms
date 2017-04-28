using System;
using System.Text;

namespace Algorithms.StdLib
{
    public static class StdIn
    {
        public static bool TryReadDouble(out double result)
        {
            StringBuilder sb = new StringBuilder();
            int val;
            while ((val = Console.Read()) != -1)
            {
                char c = (char)val;
                if (!char.IsWhiteSpace(c))
                {
                    sb.Append((char)val);
                }
                else if (sb.Length > 0)
                {
                    return double.TryParse(sb.ToString(), out result);
                }
            }

            if (sb.Length > 0)
            {
                return double.TryParse(sb.ToString(), out result);
            }

            result = 0;
            return false;
        }

        public static bool TryReadInt(out int result)
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
                    return int.TryParse(sb.ToString(), out result);
                }
            }

            if (sb.Length > 0)
            {
                return int.TryParse(sb.ToString(), out result);
            }

            result = 0;
            return false;
        }

        public static bool TryReadString(out string result)
        {
            StringBuilder sb = new StringBuilder();
            int val;
            while ((val = Console.Read()) != -1)
            {
                char c = (char)val;
                if (!char.IsWhiteSpace(c))
                {
                    sb.Append((char)val);
                }
                else if (sb.Length > 0)
                {
                    result = sb.ToString();
                    return true;
                }
            }

            if (sb.Length > 0)
            {
                result = sb.ToString();
                return true;
            }

            result = "";
            return false;
        }
    }
}
