using Aint.Domain.Extensions;
using FluentAssertions;
using NUnit.Framework;

namespace Aint.Tests.Unit
{
    [TestFixture]
    public class AllUniqueCharactersTests
    {
        [Test]
        public void OnlyHasUniqueCharacters_can_test_for_unique_characters()
        {
            //Setup.
            //Execute.
            var isUnique = "no duplicates".OnlyHasUniqueCharacters();
            var isNotUnique = "This is not unique.".OnlyHasUniqueCharacters();

            //Verify.
            isUnique.Should().BeTrue();
            isNotUnique.Should().BeFalse();

            //Teardown.
        }

        [Test]
        public void OnlyHasUniqueCharacters_will_return_false_if_more_characters_than_the_encoding_size_is_passed_in()
        {
            //Setup.
            //Execute.
            const int encodingSize = 3;
            var isUnique = "no duplicates".OnlyHasUniqueCharacters(encodingSize);

            //Verify.
            isUnique.Should().BeFalse();

            //Teardown.
        }
    }
}
