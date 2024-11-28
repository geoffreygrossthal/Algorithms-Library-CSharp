using System.Collections.Generic;

namespace Games.Sudoku
{
    public class Sudoku
    {
        // Validates Sudoku board
        // Time Complexity: O(1) for a standard 9x9 board (constant due to fixed size). 
        //                  For a generalized n^2 x n^2 board, the complexity is O(n^4).
        // Space Complexity: O(1) for a standard 9x9 board (constant due to fixed size). 
        //                   For a generalized n^2 x n^2 board, the complexity is O(n^4).
        public bool ValidSudokuBoard(char[][] board)
        {
            HashSet<string> seen = new HashSet<string>();
            for (int row = 0; row < board.Length; ++row) {
                for (int column = 0; column < board[0].Length; ++ column) {
                    char current = board[row][column];
                    if (current >= '1' && current <= '9') {
                        string rowKey = $"row-{row}-{current}";
                        string colKey = $"col-{column}-{current}";
                        string boxKey = $"box-{row / 3}-{column / 3}-{current}";
                        if (seen.Contains(rowKey) || seen.Contains(colKey) || seen.Contains(boxKey))
                            return false;
                        seen.Add(rowKey);
                        seen.Add(colKey);
                        seen.Add(boxKey);
                    }
                }
            }
            return true;
        }
    }
}
