using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Algorithms.StdLib
{
    public static class In
    {
        public static IEnumerable<int> ReadAllIntsFromFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException();
            }
            
            using (var inStream = File.OpenText(fileName))
            {
                StringBuilder sb = new StringBuilder();
                while (inStream.Peek() >= 0)
                {
                    char c = (char)inStream.Read();
                    if (char.IsDigit(c))
                    {
                        sb.Append(c);
                    }
                    else if (sb.Length > 0)
                    {
                        yield return int.Parse(sb.ToString());
                        sb.Clear();
                    }
                }
                if (sb.Length > 0)
                {
                    yield return int.Parse(sb.ToString());
                }
            }
        }
    }
}
