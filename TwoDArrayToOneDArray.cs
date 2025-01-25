using System;

class TwoDArrayToOneDArray{
    public static void Main(){
        // taking user input for the dimensions of the 2D array
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int columns = int.Parse(Console.ReadLine());

        // creating the 2D array (Matrix)
		// [,] this initialisation is different from java
        int[,] matrix = new int[rows, columns];

        // taking input for each element of the 2D array
        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < rows; i++){
            for (int j = 0; j < columns; j++){
                Console.Write("Enter element for position [{0}, {1}]: ", i, j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // creating the 1D array to store elements from the 2D array
        int[] array = new int[rows * columns];
        int index = 0; // index to keep track of the position in the 1D array

        // copying elements from the 2D array to the 1D array
        for (int i = 0; i < rows; i++){
            for (int j = 0; j < columns; j++){
                array[index] = matrix[i, j];
                index++; // incrementing the index
            }
        }

        

        // displaying the elements of the 1D array
        Console.WriteLine("\nThe 1D Array:");
        for (int i = 0; i < array.Length; i++){
            Console.Write(array[i] + " ");
        }
    }
}
