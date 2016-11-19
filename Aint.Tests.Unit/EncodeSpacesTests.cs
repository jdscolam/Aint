using Aint.Domain.Extensions;
using FluentAssertions;
using NUnit.Framework;

namespace Aint.Tests.Unit
{
    [TestFixture]
    public class EncodeSpacesTests
    {
        [Test]
        public void EncodeSpaces_can_html_encode_spaces_when_padding_is_provided()
        {
            //Setup.
            const string baseString = "Mr John Smith    ";
            const string expectedString = "Mr%20John%20Smith";
            var charArray = baseString.ToCharArray();

            //Execute.
            charArray.EncodeSpaces(13);

            //Verify.
            charArray.Should().BeEquivalentTo(expectedString.ToCharArray());

            //Teardown.
        }
    }
}
