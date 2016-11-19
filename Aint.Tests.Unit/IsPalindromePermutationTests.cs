using Aint.Domain.Extensions;
using FluentAssertions;
using NUnit.Framework;

namespace Aint.Tests.Unit
{
    [TestFixture]
    public class IsPalindromePermutationTests
    {
        [Test]
        public void IsPalindromePermutation_can_test_for_palindrome_permutations()
        {
            //Setup.
            const string palindromePermutation = "Tact Coa";
            const string palindromePermutation2 = "TactCa";
            const string palindromePermutation3 = " Tact Coa ";
            const string notAPalindromePermutation = "sTact Coa";
            const string notAPalindromePermutation2 = "TactsCoa";
            const string notAPalindromePermutation3 = " Tacst Coa ";

            //Execute.
            //Verify.
            var isAPalPer = palindromePermutation.IsPalindromePermutation().Should().BeTrue();
            var isAPalPer2 = palindromePermutation2.IsPalindromePermutation().Should().BeTrue();
            var isAPalPer3 = palindromePermutation3.IsPalindromePermutation().Should().BeTrue();
            var isNotAPalPer = notAPalindromePermutation.IsPalindromePermutation().Should().BeFalse();
            var isNotAPalPer2 = notAPalindromePermutation2.IsPalindromePermutation().Should().BeFalse();
            var isNotAPalPer3 = notAPalindromePermutation3.IsPalindromePermutation().Should().BeFalse();

            //Teardown.
        }
        [Test]
        public void IsPalindromePermutationOptimized_can_test_for_palindrome_permutations()
        {
            //Setup.
            const string palindromePermutation = "Tact Coa";
            const string palindromePermutation2 = "TactCa";
            const string palindromePermutation3 = " Tact Coa ";
            const string notAPalindromePermutation = "sTact Coa";
            const string notAPalindromePermutation2 = "TactsCoa";
            const string notAPalindromePermutation3 = " Tacst Coa ";

            //Execute.
            //Verify.
            var isAPalPer = palindromePermutation.IsPalindromePermutationOptimized().Should().BeTrue();
            var isAPalPer2 = palindromePermutation2.IsPalindromePermutationOptimized().Should().BeTrue();
            var isAPalPer3 = palindromePermutation3.IsPalindromePermutationOptimized().Should().BeTrue();
            var isNotAPalPer = notAPalindromePermutation.IsPalindromePermutationOptimized().Should().BeFalse();
            var isNotAPalPer2 = notAPalindromePermutation2.IsPalindromePermutationOptimized().Should().BeFalse();
            var isNotAPalPer3 = notAPalindromePermutation3.IsPalindromePermutationOptimized().Should().BeFalse();

            //Teardown.
        }
    }
}
