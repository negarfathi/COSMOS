using System;

namespace GetRawPathConstraints
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public string ReplaceFirstChar(string target, char c)
        {
            if (target == null) throw new ArgumentNullException();
            if (target.Length == 0) throw new ArgumentOutOfRangeException();
            return c + target.Substring(1);
        }
    }
}