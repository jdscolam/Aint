namespace Aint.Domain.Extensions
{
    public static class HtmlEncodingExtensions
    {
        public static void EncodeSpaces(this char[] charArray, int trueLength)
        {
            int i, index, spaceCount = 0;

            for (i = 0; i < trueLength; i++)
            {
                if (charArray[i] == ' ')
                    spaceCount++;
            }

            index = trueLength + spaceCount * 2;

            for (i = trueLength - 1; i >= 0; i--)
            {
                if (charArray[i] == ' ')
                {
                    charArray[index - 1] = '0';
                    charArray[index - 2] = '2';
                    charArray[index - 3] = '%';

                    index = index - 3;
                }
                else
                {
                    charArray[index - 1] = charArray[i];
                    index--;
                }
            }
        }
    }
}