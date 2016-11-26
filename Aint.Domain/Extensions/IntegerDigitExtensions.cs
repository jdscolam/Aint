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

            var sum = intToSum % 10;

            sum += SumDigitsRecursively(intToSum / 10);

            return sum;
        }
    }
}
