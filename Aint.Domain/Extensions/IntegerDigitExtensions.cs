using System;

namespace Aint.Domain.Extensions
{
    public static class IntegerDigitExtensions
    {
        public static int SumDigitsRecursively(this int intToSum)
        {
            intToSum = Math.Abs(intToSum);

            if (intToSum < 10)
                return intToSum;

            //Pluck the right-most digit.
            var sum = intToSum % 10;

            //Add the sum of the remaining digits.
            sum += SumDigitsRecursively(intToSum / 10);

            return sum;
        }
    }
}
