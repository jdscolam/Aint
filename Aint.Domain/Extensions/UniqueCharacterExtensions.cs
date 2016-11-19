namespace Aint.Domain.Extensions
{
    public static class UniqueCharacterExtensions
    {
        public static bool OnlyHasUniqueCharacters(this string input, int encodingSize = 256)
        {
            if (input.Length > encodingSize)
                return false;

            var characterFlags = new bool[encodingSize];

            for (var i = 0; i < input.Length; i++)
            {
                int value = input[i];

                if (characterFlags[value])
                    return false;

                characterFlags[value] = true;
            }

            return true;
        }
    }
}
