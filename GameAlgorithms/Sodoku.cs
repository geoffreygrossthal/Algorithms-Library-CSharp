using System.Collections.Generic;

namespace GameAlgorithms.Sudoku
{
    public class Sudoku
    {
        //Validates Sudoku board
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
