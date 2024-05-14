public class Solution {
     public int GetMaximumGold(int[][] grid)
{
    int maxGold = 0;
    for (int i = 0; i < grid.Length; i++)
    {
        for (int j = 0; j < grid[0].Length; j++)
        {
            if (grid[i][j] != 0)
            {
                bool[][]visited=new bool[grid.Length][];
                for (int k = 0; k <grid.Length ; k++)
                {
                    visited[k]=new bool[grid[0].Length];
                }
                maxGold = Math.Max(maxGold, Backtrack(grid, visited, i, j));

                }
            }
        }

    return maxGold;
    }

private int Backtrack(int[][] grid, bool[][] visited,int row,int column)
{
    if (row < 0 || row >= grid.Length || column < 0 || column >= grid[0].Length || grid[row][column] == 0 || visited[row][column])
    {
        return 0;
    }
    visited[row][column] = true;
    int maxgold = 0;

    foreach((int dr, int dc) in new (int, int)[] { (0, 1), (0, -1), (1, 0), (-1, 0) })
    {
        int newRow = row + dr;
        int newColumn = column + dc;

        maxgold = Math.Max(maxgold, Backtrack(grid, visited, newRow, newColumn));
    }

    visited[row][column] = false;

    return  grid[row][column]+  maxgold;

}
}