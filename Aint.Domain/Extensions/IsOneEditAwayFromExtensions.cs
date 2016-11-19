using System;

namespace Aint.Domain.Extensions
{
    public static class IsOneEditAwayFromExtensions
    {
        public static bool IsOneEditAwayFrom(this string baseString, string second)
        {
            //We're more than one difference away in length.
            if (Math.Abs(baseString.Length - second.Length) > 1)
                return false;

            var index1 = 0;
            var index2 = 0;

            //Get shorter and longer.
            var s1 = baseString.Length < second.Length ? baseString : second;
            var s2 = baseString.Length < second.Length ? second : baseString;

            var foundDifference = false;
            
            while (index2 < s2.Length && index1 < s1.Length)
            {
                if (s1[index1] != s2[index2])
                {
                    if (foundDifference)
                        return false;

                    foundDifference = true;

                    if (s1.Length == s2.Length)
                        index1++;
                }
                else
                    index1++;

                index2++;
            }

            return true;
        }
    }
}
