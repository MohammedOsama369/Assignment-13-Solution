using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_13_Solution
{
    internal class AnagramComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            if (x == null || y == null)
                return x == y;

            return SortCharacters(x) == SortCharacters(y);
        }

        public int GetHashCode(string obj)
        {
            return SortCharacters(obj).GetHashCode();
        }

        private string SortCharacters(string word)
        {
            return new string(word.ToLower()
                                  .OrderBy(c => c)
                                  .ToArray()
            );
        }
    }
}
