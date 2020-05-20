using System;
using System.Collections.Generic;

namespace code_sample
{
    public static class StringSearch
    {
        /// <summary>
        /// Binary search algorithm for strings, returning true if an ordered strList contains str, and false otherwise
        /// </summary>
        /// <param name="strList"></param>
        /// <param name="str"></param>
        /// <returns>bool</returns>
        public static bool BinarySearch(IList<string> strList, string str)
        {
            int high = strList.Count - 1;
            int low = 0;

            while (low <= high)
            {
                int mid = (high + low) >> 1;
                int order = str.CompareTo(strList[mid]);

                if (order == 0)
                    return true;

                if (order < 0)
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return false;
        }
    }
}