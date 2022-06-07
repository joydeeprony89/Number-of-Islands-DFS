using System;
using System.Collections.Generic;

namespace Number_of_Islands
{
  class Program
  {
    static void Main(string[] args)
    {
      char[][] grid = new char[4][]
      {
        new char[] { '1', '1', '0', '0', '0' }, 
        new char[] { '1', '1', '0', '0', '0' }, 
        new char[] { '0', '0', '1', '0', '0' }, 
        new char[] { '0', '0', '0', '1', '1' } 
      };
      Solution s = new Solution();
      var result = s.NumIslands(grid);
      Console.WriteLine(result);
    }
  }

  public class Solution
  {
    int ROW = 0;
    int COLUMN = 0;
    public int NumIslands(char[][] grid)
    {
      if (grid == null || grid.Length == 0) return 0;
      ROW = grid.Length;
      COLUMN = grid[0].Length;
      int count = 0;
      for (int i = 0; i < ROW; i++)
      {
        for (int j = 0; j < COLUMN; j++)
        {
          string visitedStr = i.ToString() + j.ToString();
          if (grid[i][j] == '1')
          {
            DFS(grid, i, j);
            count++;
          }
        }
      }

      return count;
    }

    private void DFS(char[][] grid, int i, int j)
    {
      // base condition, when to break the recursion
      if (i < 0 || j < 0 || i >= ROW || j >= COLUMN || grid[i][j] == '0') return;
      grid[i][j] = '0';

      DFS(grid, i, j + 1);
      DFS(grid, i, j - 1);
      DFS(grid, i + 1, j);
      DFS(grid, i - 1, j);
    }
  }
}
