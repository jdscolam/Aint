using System;

namespace Aint.Domain.Extensions
{
    public static class StringSortExtensions
    {
        public static string SortString(this string stringToSort)
        {
            var sortedCharacters = stringToSort.ToCharArray();
            Array.Sort(sortedCharacters);

            return new string(sortedCharacters);
        }
    }
}
