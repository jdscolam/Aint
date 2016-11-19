using System;

namespace Aint.Domain.Extensions
{
    public static class IsPermutationExtensions
    {
        public static bool IsPermutation(this string baseString, string testString)
        {
            var isPermutation = baseString.Length == testString.Length && baseString.SortString() == testString.SortString();

            return isPermutation;
        }
        public static bool IsPermutationOptimized(this string baseString, string testString, int encodingSize = 256)
        {
            if (baseString.Length != testString.Length)
                return false;

            var letters = new int[encodingSize];

            for (var i = 0; i < baseString.Length; i++)
            {
                letters[baseString[i]]++;
            }

            for (var i = 0; i < testString.Length; i++)
            {
                letters[testString[i]]--;

                if (letters[testString[i]] < 0)
                    return false;
            }

            return true;
        }

        public static bool IsPalindromePermutation(this string baseString)
        {
            var table = baseString.BuildCharacterFrequencyTable();

            var onlyOneOddCharacter = CheckOnlyOneOddCharacterCount(table);

            return onlyOneOddCharacter;
        }

        public static bool IsPalindromePermutationOptimized(this string baseString)
        {
            var bitVector = CreateBitVector(baseString);
            var evenOrOnlyOneBit = bitVector == 0 || CheckOnlyOneBitSet(bitVector);

            return evenOrOnlyOneBit;
        }

        private static bool CheckOnlyOneBitSet(int bitVector)
        {
            return (bitVector & (bitVector - 1)) == 0;
        }

        private static int CreateBitVector(string baseString)
        {
            var bitVector = 0;

            for (var i = 0; i < baseString.Length; i++)
            {
                var x = baseString[i].GetCharIndex();

                bitVector = Toggle(bitVector, x);
            }

            return bitVector;
        }

        private static int Toggle(int bitVector, int index)
        {
            if (index < 0)
                return bitVector;

            var mask = 1 << index;

            if ((bitVector & mask) == 0)
                bitVector |= mask;
            else
                bitVector &= ~mask;

            return bitVector;
        }

        private static bool CheckOnlyOneOddCharacterCount(int[] table)
        {
            var foundOdd = false;

            foreach (var count in table)
            {
                if (count%2 != 1)
                    continue;

                if (foundOdd)
                    return false;

                foundOdd = true;
            }

            return true;
        }
    }
}
