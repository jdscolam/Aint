using Aint.Domain.Extensions;
using FluentAssertions;
using NUnit.Framework;

namespace Aint.Tests.Unit
{
    [TestFixture]
    public class StringToIntTests
    {
        [Test]
        public void ConvertToIntRecursively_can_convert_a_string_to_an_integer()
        {
            //Setup.
            const string stringToConvert = "12345";

            //Execute.
            var converted = stringToConvert.ConvertToIntRecursively();

            //Verify.
            converted.ShouldBeEquivalentTo(12345);

            //Teardown.
        }

        [Test]
        public void ConvertToIntRecursively_can_handle_non_numeric_characters()
        {
            //Setup.
            const string stringToConvert = "12,345";
            const string stringToConvert2 = "123 45";

            //Execute.
            var converted = stringToConvert.ConvertToIntRecursively();
            var converted2 = stringToConvert2.ConvertToIntRecursively();

            //Verify.
            converted.ShouldBeEquivalentTo(12345);
            converted2.ShouldBeEquivalentTo(12345);

            //Teardown.
        }

        [Test]
        public void ConvertToIntRecursively_can_handle_negative_values()
        {
            //Setup.
            const string stringToConvert = "-12345";

            //Execute.
            var converted = stringToConvert.ConvertToIntRecursively();

            //Verify.
            converted.ShouldBeEquivalentTo(-12345);

            //Teardown.
        }

        [Test]
        public void ConvertToIntRecursively_can_handle_decimals()
        {
            //Setup.
            const string stringToConvert = "123.45";
            const string stringToConvert2 = ".12345";

            //Execute.
            var converted = stringToConvert.ConvertToIntRecursively();
            var converted2 = stringToConvert2.ConvertToIntRecursively();

            //Verify.
            converted.ShouldBeEquivalentTo(123);
            converted2.ShouldBeEquivalentTo(0);

            //Teardown.
        }
    }
}