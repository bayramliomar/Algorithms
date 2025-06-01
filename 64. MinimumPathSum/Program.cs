/*
 Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right, which minimizes the sum of all numbers along its path.

 Note: You can only move either down or right at any point in time.

Input: grid = [[1,3,1],[1,5,1],[4,2,1]]
Output: 7
Explanation: Because the path 1 → 3 → 1 → 1 → 1 minimizes the sum.

Constraints:

m == grid.length
n == grid[i].length
1 <= m, n <= 200
0 <= grid[i][j] <= 200
 
1   3   1
1   5   1
4   2   1

[2,4,1,5,6],
[3,3,2,6,7],
[1,4,5,3,5]
 */

int[][] grid = {
            [1,3,1],
            [1,5,1],
            [4,2,1]
        };

int result = MinPathSum(grid);
;

int MinPathSum(int[][] grid)
{
    return FindMinPath(grid, 0, 0);
}


int FindMinPath(int[][] grid, int i, int j)
{
    int m = grid.Length;
    int n = grid[0].Length;

    // Base case: bottom-right cell
    if (i == m - 1 && j == n - 1)
    {
        return grid[i][j];
    }

    // Moving down
    if (i < m - 1 && j < n - 1)
    {
        return grid[i][j] + Math.Min(FindMinPath(grid, i + 1, j), FindMinPath(grid, i, j + 1));
    }
    else if (i < m - 1)
    {  // Move only down
        return grid[i][j] + FindMinPath(grid, i + 1, j);
    }
    else if (j < n - 1)
    {  // Move only right
        return grid[i][j] + FindMinPath(grid, i, j + 1);
    }

    return int.MaxValue;
}

Console.ReadLine();