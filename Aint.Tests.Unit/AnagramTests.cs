using Aint.Domain.Extensions;
using NUnit.Framework;

namespace Aint.Tests.Unit
{
    [TestFixture]
    public class AnagramTests
    {
        [Test]
        public void FindAnagramIndexes_can_find_all_indexes_of_anagram_instances()
        {
            //Setup.
            const string initialString = "ab";
            const string stringToSearch = "bbababbbbaabababba";

            //Execute.
            var anagramsFoundAt = stringToSearch.FindAllAnagramIndexes(initialString);

            //Verify.


            //Teardown.
        }
    }
}
