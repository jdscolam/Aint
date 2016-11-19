using System.Collections.Generic;

namespace Aint.Domain.Extensions
{
    public static class AnagramExtensions
    {
        private static bool StringArraysMatch(int[] first, int[] second, int maxPotentialCharacters = 256)
        {
            for (var i = 0; i < maxPotentialCharacters; i++)
            {
                if (first[i] != second[i])
                    return false;
            }

            return true;
        }

        public static List<int> FindAllAnagramIndexes(this string baseString, string stringToTest, int maxPotentialCharacters = 256)
        {
            var stringToTestLength = stringToTest.Length;
            var baseStringLength = baseString.Length;
            var anagramFoundAtIndexes = new List<int>();

            var countOfAllCharactersInStringToTest = new int[maxPotentialCharacters];
            var countOfCurrentTextWindow = new int[maxPotentialCharacters];

            //Get the stringToTest character counts, and check the first window in baseString.
            for (var i = 0; i < stringToTestLength; i++)
            {
                countOfAllCharactersInStringToTest[stringToTest[i]]++;
                countOfCurrentTextWindow[baseString[i]]++;
            }

            //Check all but the last window in baseString.
            for (var i = stringToTestLength; i < baseStringLength; i++)
            {
                if (StringArraysMatch(countOfAllCharactersInStringToTest, countOfCurrentTextWindow))
                    anagramFoundAtIndexes.Add(i - stringToTestLength);

                countOfCurrentTextWindow[baseString[i]]++;

                countOfCurrentTextWindow[baseString[i - stringToTestLength]]--;
            }

            //Check the last window in baseString.
            if (StringArraysMatch(countOfAllCharactersInStringToTest, countOfCurrentTextWindow))
                anagramFoundAtIndexes.Add(baseStringLength - stringToTestLength);

            return anagramFoundAtIndexes;
        }
    }
}