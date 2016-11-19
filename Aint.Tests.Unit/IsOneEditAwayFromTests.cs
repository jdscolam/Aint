using Aint.Domain.Extensions;
using FluentAssertions;
using NUnit.Framework;

namespace Aint.Tests.Unit
{
    [TestFixture]
    public class IsOneEditAwayFromTests
    {
        [Test]
        public void IsOneEditAwayFrom_can_tell_if_two_strings_are_one_edit_away()
        {
            //Setup.
            //Execute.
            var isOneInsertAway = "pale".IsOneEditAwayFrom("ple");
            var isOneDeleteAway = "pales".IsOneEditAwayFrom("pale");
            var isOneReplaceAway = "pale".IsOneEditAwayFrom("bale");
            var isNotOneEditAway = "pale".IsOneEditAwayFrom("bae");

            //Verify.
            isOneInsertAway.Should().BeTrue();
            isOneDeleteAway.Should().BeTrue();
            isOneReplaceAway.Should().BeTrue();
            isNotOneEditAway.Should().BeFalse();

            //Teardown.
        }
    }
}
