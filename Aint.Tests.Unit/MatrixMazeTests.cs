using Aint.Domain.Extensions;
using Aint.Domain.Model;
using FluentAssertions;
using NUnit.Framework;

namespace Aint.Tests.Unit
{
    [TestFixture]
    public class MatrixMazeTests
    {
        [Test]
        public void FindShortestPath_can_find_the_shortest_path_through_a_binary_matrix_maze()
        {
            //Setup.
            var maze = new [,]
            {
                { 1, 0, 1, 1, 1, 1, 0, 1, 1, 1 },
                { 1, 0, 1, 0, 1, 1, 1, 0, 1, 1 },
                { 1, 1, 1, 0, 1, 1, 0, 1, 0, 1 },
                { 0, 0, 0, 0, 1, 0, 0, 0, 0, 1 },
                { 1, 1, 1, 0, 1, 1, 1, 0, 1, 0 },
                { 1, 0, 1, 1, 1, 1, 0, 1, 0, 0 },
                { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                { 1, 0, 1, 1, 1, 1, 0, 1, 1, 1 },
                { 1, 1, 0, 0, 0, 0, 1, 0, 0, 1 }
            };

            var start = new Point {X = 0, Y = 0};
            var end = new Point { X = 3, Y = 4 };

            //Execute.
            var distance = maze.FindShortestPath(9, 10, start, end, 1);

            //Verify.
            distance.ShouldBeEquivalentTo(11);

            //Teardown.

        }
    }
}
