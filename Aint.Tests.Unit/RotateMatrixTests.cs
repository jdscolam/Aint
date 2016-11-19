using Aint.Domain.Extensions;
using NUnit.Framework;

namespace Aint.Tests.Unit
{
    [TestFixture]
    public class RotateMatrixTests
    {
        [Test]
        public void RotateMatrixInPlace90Degrees_can_rotate_a_matrix()
        {
            //Setup.
            var matrix = new[]
            {
                new[]   {10, 11, 12, 20}
                , new[] {42, 50, 60, 21}
                , new[] {41, 80, 70, 22}
                , new[] {40, 32, 31, 30}
            };
            
            //Execute.
            matrix.RotateMatrixInPlace90Degrees();

            //Verify.


            //Teardown.
        }
    }
}
