using Aint.Domain.Extensions;
using FluentAssertions;
using NUnit.Framework;

namespace Aint.Tests.Unit
{
    [TestFixture]
    public class IsPermutationTests
    {
        [Test]
        public void IsPermutation_can_identify_permutations_of_a_string()
        {
            //Setup.
            const string baseString = "sink";
            const string permutation = "knis";
            const string permutation2 = "niks";
            const string notAPermutation = "sink ";
            const string notAPermutation2 = "Sink";
            const string notAPermutation3 = "sinK";

            //Execute.
            var isPermutation = baseString.IsPermutation(permutation);
            var isPermutation2 = baseString.IsPermutation(permutation2);
            var notPermutation = baseString.IsPermutation(notAPermutation);
            var notPermutation2 = baseString.IsPermutation(notAPermutation2);
            var notPermutation3 = baseString.IsPermutation(notAPermutation3);

            //Verify.
            isPermutation.Should().BeTrue();
            isPermutation2.Should().BeTrue();
            notPermutation.Should().BeFalse();
            notPermutation2.Should().BeFalse();
            notPermutation3.Should().BeFalse();

            //Teardown.
        }
        [Test]
        public void IsPermutationOptimized_can_identify_permutations_of_a_string()
        {
            //Setup.
            const string baseString = "sink";
            const string permutation = "knis";
            const string permutation2 = "niks";
            const string notAPermutation = "sink ";
            const string notAPermutation2 = "Sink";
            const string notAPermutation3 = "sinK";

            //Execute.
            var isPermutation = baseString.IsPermutationOptimized(permutation);
            var isPermutation2 = baseString.IsPermutationOptimized(permutation2);
            var notPermutation = baseString.IsPermutationOptimized(notAPermutation);
            var notPermutation2 = baseString.IsPermutationOptimized(notAPermutation2);
            var notPermutation3 = baseString.IsPermutationOptimized(notAPermutation3);

            //Verify.
            isPermutation.Should().BeTrue();
            isPermutation2.Should().BeTrue();
            notPermutation.Should().BeFalse();
            notPermutation2.Should().BeFalse();
            notPermutation3.Should().BeFalse();

            //Teardown.
        }
    }
}
