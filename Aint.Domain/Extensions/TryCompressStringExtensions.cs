using System.Text;

namespace Aint.Domain.Extensions
{
    public static class TryCompressStringExtensions
    {
        public static string TryCompressString(this string baseString)
        {
            var finalLength = CountCompression(baseString);

            if(finalLength >= baseString.Length)
                return baseString;
            
            var compressed = new StringBuilder(finalLength);
            var countConsecutive = 0;

            for (var i = 0; i < baseString.Length; i++)
            {
                countConsecutive++;

                if (i + 1 >= baseString.Length || baseString[i] != baseString[i + 1])
                {
                    compressed.Append(baseString[i]);
                    compressed.Append(countConsecutive);
                    countConsecutive = 0;
                }
            }

            return compressed.ToString();
        }

        private static int CountCompression(string baseString)
        {
            var compressedLength = 0;
            var countConsecutive = 0;

            for (var i = 0; i < baseString.Length; i++)
            {
                countConsecutive++;

                if (i + 1 >= baseString.Length || baseString[i] != baseString[i + 1])
                {
                    compressedLength += 1 + countConsecutive.ToString().Length;
                    countConsecutive = 0;
                }
            }

            return compressedLength;
        }
    }
}
