public class Solution {
        public int MatrixScore(int[][] grid)
    {
    int row= grid.Length;
    int column = grid[0].Length;

    for (int i = 0; i < row; i++) // check if the leftmost bit in a row is 0 and flip it
    {
        if (grid[i][0] == 0)
        {
            for (int j = 0; j < column; j++)
            {
                grid[i][j] = 1 - grid[i][j]; // reverse the value of 0's and 1's
            }
        }
    }
    // calculate numbers of0's in the cloumn
    for (int j = 1;j < column; j++)
    {
        int countzero = 0;
        for (int i = 0; i < row; i++)
        {
            if(grid[i][j]==0){
                countzero++;
            }
        }


        if (countzero > row-countzero)
        {
            for (int i = 0; i <row; i++)
            {
                grid[i][j] = 1 - grid[i][j];
            }
        }
    }

    int score = 0;

 foreach (var Row in grid)
 {
     score += Convert.ToInt32(string.Join("", Row), 2);
 }

    return score;

}
}