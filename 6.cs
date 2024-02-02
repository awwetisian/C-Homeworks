using System;

class Program
{
    static void Main()
    {
        int rows = 3; // Replace with your desired number of rows
        int cols = 4; // Replace with your desired number of columns

        int[,] matrix = new int[rows, cols];
        Random rand = new Random();

        // Flatten the matrix to a 1D array for easier tracking of used numbers
        int totalElements = rows * cols;
        int[] usedNumbers = new int[totalElements];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int randomNumber;

                do
                {
                    randomNumber = rand.Next(1, totalElements + 1);
                } while (Array.IndexOf(usedNumbers, randomNumber) != -1);

                matrix[i, j] = randomNumber;
                usedNumbers[i * cols + j] = randomNumber;

                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
