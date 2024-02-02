using System;
using System.Collections.Generic;

class KnightMove
{
    static int boardSize = 8;
    static int[,] chessboard = new int[boardSize, boardSize];
    static Random random = new Random();

    static void Main()
    {
        // Set the initial position of the knight (example: row 2, column 3)
        int initialRow = 2;
        int initialCol = 3;

        // Make a random move from the initial position
        MakeRandomMove(initialRow, initialCol);

        // Display the updated chessboard
        DisplayChessboard();
    }

    static void MakeRandomMove(int currentRow, int currentCol)
    {
        // List possible moves for the knight
        List<Tuple<int, int>> possibleMoves = GetPossibleMoves(currentRow, currentCol);

        if (possibleMoves.Count == 0)
        {
            Console.WriteLine("No more valid moves.");
            return;
        }

        // Choose a random move
        Tuple<int, int> randomMove = possibleMoves[random.Next(possibleMoves.Count)];

        // Update chessboard and make the move
        chessboard[currentRow, currentCol] = 0; // Clear the current position
        currentRow = randomMove.Item1;
        currentCol = randomMove.Item2;
        chessboard[currentRow, currentCol] = 1; // Mark the new position
    }

    static List<Tuple<int, int>> GetPossibleMoves(int row, int col)
    {
        List<Tuple<int, int>> moves = new List<Tuple<int, int>>();

        int[] rowMoves = { 2, 1, -1, -2, -2, -1, 1, 2 };
        int[] colMoves = { 1, 2, 2, 1, -1, -2, -2, -1 };

        for (int i = 0; i < 8; i++)
        {
            int newRow = row + rowMoves[i];
            int newCol = col + colMoves[i];

            if (IsValidMove(newRow, newCol))
            {
                moves.Add(Tuple.Create(newRow, newCol));
            }
        }

        return moves;
    }

    static bool IsValidMove(int row, int col)
    {
        return row >= 0 && row < boardSize && col >= 0 && col < boardSize && chessboard[row, col] == 0;
    }

    static void DisplayChessboard()
    {
        Console.WriteLine("Updated Chessboard:");
        for (int i = 0; i < boardSize; i++)
        {
            for (int j = 0; j < boardSize; j++)
            {
                Console.Write(chessboard[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
