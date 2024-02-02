using System;

class Program
{
    static void Main()
    {
        int[,] chessMatrix = new int[8, 8];

        // Set the position of the queen (example: row 3, column 5)
        int queenRow = 3;
        int queenCol = 5;

        // Mark horizontal, vertical, and diagonal strokes
        MarkStrokes(chessMatrix, queenRow, queenCol);

        // Display the matrix
        DisplayMatrix(chessMatrix);
    }

    static void MarkStrokes(int[,] matrix, int row, int col)
    {
        // Mark horizontal strokes
        for (int i = 0; i < 8; i++)
        {
            matrix[row, i] = 1;
        }

        // Mark vertical strokes
        for (int i = 0; i < 8; i++)
        {
            matrix[i, col] = 1;
        }

        // Mark diagonal strokes
        for (int i = 0; i < 8; i++)
        {
            if (IsInBounds(row + i, col + i))
            {
                matrix[row + i, col + i] = 1;
            }

            if (IsInBounds(row - i, col + i))
            {
                matrix[row - i, col + i] = 1;
            }

            if (IsInBounds(row + i, col - i))
            {
                matrix[row + i, col - i] = 1;
            }

            if (IsInBounds(row - i, col - i))
            {
                matrix[row - i, col - i] = 1;
            }
        }
    }

    static void DisplayMatrix(int[,] matrix)
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static bool IsInBounds(int row, int col)
    {
        return row >= 0 && row < 8 && col >= 0 && col < 8;
    }
}