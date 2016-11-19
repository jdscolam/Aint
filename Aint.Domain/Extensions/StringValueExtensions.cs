namespace Aint.Domain.Extensions
{
    public static class StringValueExtensions
    {
        public static int[] BuildCharacterFrequencyTable(this string baseString)
        {
            const int arrayLength = 'z' - 'a' + 1;

            var table = new int[arrayLength];

            for(var i = 0; i < baseString.Length; i++)
            {
                var x = baseString[i].GetCharIndex();

                if (x != -1)
                    table[x]++;
            }

            return table;
        }

        public static int GetCharIndex(this char c)
        {
            const int a = 'a';
            const int z = 'z';

            if (char.IsWhiteSpace(c))
                return -1;

            int val = char.ToLower(c);

            return a <= val && val <= z ? val - a : -1;
        }

        public static int GetCharValueFromIndex(this int charIndex)
        {
            const int a = 'a';

            if (charIndex > 26)
                return -1;
            
            return charIndex + a;
        }
    }
}