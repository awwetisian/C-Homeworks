using System;

class Program
{
    static void Main()
    {
        int[,] chessboard = new int[8, 8];

        // Assuming the starting position of the horse is at (0, 0)
        int currentRow = 0;
        int currentCol = 0;

        // Mark the initial position of the horse
        chessboard[currentRow, currentCol] = 1;

        // Possible moves for a horse
        int[] moveRow = { 2, 1, -1, -2, -2, -1, 1, 2 };
        int[] moveCol = { 1, 2, 2, 1, -1, -2, -2, -1 };

        // Move the horse randomly for demonstration purposes
        Random random = new Random();

        for (int i = 0; i < 10; i++)
        {
            int randomMove = random.Next(8);

            int newRow = currentRow + moveRow[randomMove];
            int newCol = currentCol + moveCol[randomMove];

            // Check if the new position is within the chessboard
            if (newRow >= 0 && newRow < 8 && newCol >= 0 && newCol < 8)
            {
                currentRow = newRow;
                currentCol = newCol;

                // Mark the new position of the horse
                chessboard[currentRow, currentCol] = 1;
            }
        }

        // Display the chessboard
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                Console.Write(chessboard[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}