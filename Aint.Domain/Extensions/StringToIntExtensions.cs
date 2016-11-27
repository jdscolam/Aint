using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Aint.Domain.Extensions
{
    public static class StringToIntExtensions
    {
        public static int ConvertToIntRecursively(this string stringToConvert)
        {
            var sign = 1;

            //Prep string by removing non-numeric or sign characters.
            stringToConvert = Regex.Replace(stringToConvert, "[^0-9.-]", "");

            if(stringToConvert[0] == '-')
            {
                stringToConvert = stringToConvert.Remove(0, 1);
                sign = -1;
            }

            if (stringToConvert[0] == '.')
                return 0;

            //The result will come out negative if we've hit a decimal, so we'll get the absolute value then apply the appropriate sign.
            var value = sign * Math.Abs(ConvertToIntInternal(stringToConvert));

            return value;
        }

        private static int ConvertToIntInternal(this string stringToConvert)
        {
            //break if we're at the end.
            if (stringToConvert.Length == 1)
                return CharUnicodeInfo.GetDecimalDigitValue(stringToConvert[0]);

            var currentDigitChar = stringToConvert[stringToConvert.Length - 1];

            var currentDigit = CharUnicodeInfo.GetDecimalDigitValue(currentDigitChar);

            if (currentDigit == -1)
                return -1 * ConvertToIntInternal(stringToConvert.Remove(stringToConvert.Length - 1));

            var resultToLeftOfCurrentDigit = ConvertToIntInternal(stringToConvert.Remove(stringToConvert.Length - 1));

            //We hit a decimal.
            if (resultToLeftOfCurrentDigit < 0)
                return resultToLeftOfCurrentDigit;

            var total = currentDigit + 10 * ConvertToIntInternal(stringToConvert.Remove(stringToConvert.Length - 1));
            return total;
        }
    }
}
