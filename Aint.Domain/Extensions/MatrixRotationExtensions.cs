namespace Aint.Domain.Extensions
{
    public static class MatrixRotationExtensions
    {
        public static void RotateMatrixInPlace90Degrees(this int[][] matrix)
        {
            if (matrix.Length == 0 || matrix.Length != matrix[0].Length)
                return;

            var n = matrix.Length;

            for (int layer = 0; layer < n/2; layer++)
            {
                var first = layer;
                var last = n - 1 - layer;

                for (var i = first; i < last; i++)
                {
                    var offset = i - first;

                    //save top.
                    var top = matrix[first][i];

                    //left to top.
                    matrix[first][i] = matrix[last - offset][first];

                    //bottom to left.
                    matrix[last-offset][first] = matrix[last][last-offset];

                    //right to bottom.
                    matrix[last][last - offset] = matrix[i][last];

                    //top to right with saved top.
                    matrix[i][last] = top; 
                }
            }
        }
    }
}
