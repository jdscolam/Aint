using Aint.Domain.Extensions;
using FluentAssertions;
using NUnit.Framework;

namespace Aint.Tests.Unit
{
    [TestFixture]
    public class TryCompressStringTests
    {
        [Test]
        public void TryCompressString_can_compress_strings()
        {
            //Setup.
            const string expectedCompressedString = "a2b1c5a3";
            const string nonCompressedString = "not easily compressed";

            //Execute.
            //Verify.
            "aabcccccaaa".TryCompressString().Should().BeEquivalentTo(expectedCompressedString);
            nonCompressedString.TryCompressString().Should().BeEquivalentTo(nonCompressedString);

            //Teardown.
        }
    }
}
