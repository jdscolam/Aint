using System.Collections.Generic;
using Aint.Domain.Model;

namespace Aint.Domain.Extensions
{
    public static class MatrixMazeExtensions
    {
        private static bool IsValidCell(Point cell, int maxRow, int maxCol)
        {
            return cell.X >= 0
                   && cell.X < maxRow
                   && cell.Y >= 0
                   && cell.Y < maxCol;
        }

        public static int FindShortestPath(this int[,] maze
            , int mazeRowCount
            , int mazeColCount
            , Point start
            , Point end
            , int pathIndicator = 0)
        {
            const int pathNotFound = -1;
            var surroundingRowModifiers = new[] { -1, 0, 0, 1 };
            var surroundingColModifiers = new[] { 0, -1, 1, 0 };

            //Can't start or end at a wall.
            if (maze[start.X, start.Y] != pathIndicator
                || maze[end.X, end.Y] != pathIndicator)
                return pathNotFound;

            //Track where we've visited.
            var visited = new bool[mazeRowCount, mazeColCount];
            visited[start.X, start.Y] = true;

            //Set a queue of nodes to test, starting from the start node.
            var queue = new Queue<MazeNode>();
            var startNode = new MazeNode { CellLocation = start, Distance = 0 };
            queue.Enqueue(startNode);

            while (queue.Count != 0)
            {
                var current = queue.Dequeue();
                var currentLocation = current.CellLocation;

                //We're at the end, return the distance travelled.
                if (currentLocation.X == end.X && currentLocation.Y == end.Y)
                    return current.Distance;

                //Loop through the adjacent cells and test for a path.
                for (var i = 0; i < 4; i++)
                {
                    var adjacentCell = new Point
                    {
                        X = currentLocation.X + surroundingRowModifiers[i]
                        , Y = currentLocation.Y + surroundingColModifiers[i]
                    };
                    
                    //If adjacent cell is invalid, doesn't have a path, or we've visited it, skip.
                    if (!IsValidCell(adjacentCell, mazeRowCount, mazeColCount)
                        || maze[adjacentCell.X, adjacentCell.Y] != pathIndicator 
                        || visited[adjacentCell.X, adjacentCell.Y])
                        continue;

                    //Mark the adjacent cell as visited, and add it to the queue
                    visited[adjacentCell.X, adjacentCell.Y] = true;
                    queue.Enqueue(new MazeNode
                    {
                        CellLocation = adjacentCell
                        , Distance = current.Distance + 1
                    });
                }
            }

            return pathNotFound;;
        }
    }
}
