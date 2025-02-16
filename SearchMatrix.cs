namespace ConsoleApp1;

using System;
class Program{
    static bool SearchMatrix(int[,] matrix, int target){
        if (matrix == null || matrix.Length == 0)
            return false;
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int left = 0, right = rows * cols - 1;
        while (left <= right){
            int mid = left + (right - left) / 2;
            int row = mid / cols;
            int col = mid % cols;
            int midValue = matrix[row, col];
            if (midValue == target)
                return true;
            else if (midValue < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return false;
    }
    static void Main(){
        int[,] matrix = {
            {1, 2, 5, 8},
            {9, 12, 16, 20},
            {23, 30, 32, 55}
        };
        int target = 32;
        bool result = SearchMatrix(matrix, target);
        Console.WriteLine($"{target} Found? {result}"); 
    }
}
