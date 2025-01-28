using System;

public class MatrixOperations
{
    // Method to create a random matrix of given rows and columns
    public static double[,] CreateRandomMatrix(int rows, int columns)
    {
        Random random = new Random();
        double[,] matrix = new double[rows, columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = random.Next(1, 10); // Random values between 1 and 9
            }
        }
        return matrix;
    }

    // Method to display a matrix
    public static void DisplayMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Method to add two matrices
    public static double[,] AddMatrices(double[,] matrix1, double[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        double[,] result = new double[rows, cols];

        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
        {
            throw new Exception("Matrices must have the same dimensions to add.");
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }

    // Method to subtract two matrices
    public static double[,] SubtractMatrices(double[,] matrix1, double[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        double[,] result = new double[rows, cols];

        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
        {
            throw new Exception("Matrices must have the same dimensions to subtract.");
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        return result;
    }

    // Method to multiply two matrices
    public static double[,] MultiplyMatrices(double[,] matrix1, double[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        if (cols1 != rows2)
        {
            throw new Exception("The number of columns in the first matrix must equal the number of rows in the second matrix.");
        }

        double[,] result = new double[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < cols1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }

    // Method to find the transpose of a matrix
    public static double[,] TransposeMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] transpose = new double[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transpose[j, i] = matrix[i, j];
            }
        }

        return transpose;
    }

    // Method to calculate the determinant of a 2x2 matrix
    public static double Determinant(double[,] matrix)
    {
        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }

        throw new Exception("This method is only for 2x2 matrices.");
    }

    // Method to calculate the inverse of a 2x2 matrix
    public static double[,] Inverse(double[,] matrix)
    {
        double determinant = Determinant(matrix);
        if (determinant == 0)
        {
            throw new Exception("Matrix is singular and cannot have an inverse.");
        }

        double[,] inverse = new double[2, 2];
        inverse[0, 0] = matrix[1, 1] / determinant;
        inverse[0, 1] = -matrix[0, 1] / determinant;
        inverse[1, 0] = -matrix[1, 0] / determinant;
        inverse[1, 1] = matrix[0, 0] / determinant;

        return inverse;
    }

    public static void Main()
    {
        // Create random 2x2 matrices for testing
        double[,] matrix1 = CreateRandomMatrix(2, 2);
        double[,] matrix2 = CreateRandomMatrix(2, 2);

        Console.WriteLine("Matrix 1:");
        DisplayMatrix(matrix1);

        Console.WriteLine("\nMatrix 2:");
        DisplayMatrix(matrix2);

        // Add matrices
        Console.WriteLine("\nMatrix 1 + Matrix 2:");
        double[,] sum = AddMatrices(matrix1, matrix2);
        DisplayMatrix(sum);

        // Subtract matrices
        Console.WriteLine("\nMatrix 1 - Matrix 2:");
        double[,] difference = SubtractMatrices(matrix1, matrix2);
        DisplayMatrix(difference);

        // Multiply matrices
        Console.WriteLine("\nMatrix 1 * Matrix 2:");
        double[,] product = MultiplyMatrices(matrix1, matrix2);
        DisplayMatrix(product);

        // Transpose Matrix 1
        Console.WriteLine("\nTranspose of Matrix 1:");
        double[,] transpose = TransposeMatrix(matrix1);
        DisplayMatrix(transpose);

        // Determinant of a 2x2 matrix
        Console.WriteLine("\nDeterminant of Matrix 1: " + Determinant(matrix1));

        // Inverse of a 2x2 matrix
        Console.WriteLine("\nInverse of Matrix 1:");
        double[,] inverse = Inverse(matrix1);
        DisplayMatrix(inverse);
    }
}
