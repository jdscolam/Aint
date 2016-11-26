using Aint.Domain.Extensions;
using FluentAssertions;
using NUnit.Framework;

namespace Aint.Tests.Unit
{
    [TestFixture]
    public class SumDigitsTests
    {
        [Test]
        public void SumDigitsRecursively_can_return_the_sum_of_integers()
        {
            //Setup.
            const int intToSum = 12345;
            const int expectedSum = 15;

            //Execute.
            var sum = intToSum.SumDigitsRecursively();

            //Verify.
            sum.ShouldBeEquivalentTo(expectedSum);

            //Teardown.
        }

        [Test]
        public void SumDigitsRecursively_can_return_the_sum_of_negative_integers()
        {
            //Setup.
            const int intToSum = -12345;
            const int expectedSum = 15;

            //Execute.
            var sum = intToSum.SumDigitsRecursively();

            //Verify.
            sum.ShouldBeEquivalentTo(expectedSum);

            //Teardown.
        }

        [Test]
        public void SumDigitsRecursively_can_return_the_sum_of_single_integers()
        {
            //Setup.
            const int intToSum = 8;
            const int expectedSum = 8;

            //Execute.
            var sum = intToSum.SumDigitsRecursively();

            //Verify.
            sum.ShouldBeEquivalentTo(expectedSum);

            //Teardown.
        }
    }
}
