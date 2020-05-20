using System;
using System.Collections.Generic;

namespace code_sample
{
    public static class UniqueCharacters
    {
        /// <summary>
        /// Returns true if incoming string has at least one duplicate character, and false otherwise 
        /// </summary>
        /// <param name="str"></param>
        /// <returns>bool</returns>
        public static bool UniqueChars(string str)
        {
            var seenIt = new Dictionary<char, bool>();

            foreach (char c in str)
            {
                if (seenIt.ContainsKey(c))
                    return false;

                seenIt[c] = true;
            }

            return true;
        }
    }
}