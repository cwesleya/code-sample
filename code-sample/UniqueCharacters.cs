using System;
using System.Collections.Generic;

namespace code_sample
{
    public static class UniqueCharacters
    {
        /// <summary>
        /// Returns false if str has at least one duplicate character, and true otherwise 
        /// </summary>
        /// <param name="str"></param>
        /// <returns>bool</returns>
        public static bool UniqueChars(string str)
        {
            var seenIt = new HashSet<char>();

            foreach (char c in str)
            {
                if (seenIt.Contains(c))
                    return false;

                seenIt.Add(c);
            }

            return true;
        }
    }
}