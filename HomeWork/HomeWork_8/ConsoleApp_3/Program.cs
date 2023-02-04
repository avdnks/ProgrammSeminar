// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] GetRandomMatrix (int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int [rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplicationMatrix (int[,] matrix, int[,] matrix2)
{
    int[,] resultmatrix = new int [matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            resultmatrix[i, j] = matrix[i, j] * matrix2[i, j];
        }
    }
    return resultmatrix;
}

const int ROWS = 2;
const int COLUMNS = 2;
const int LEFT_RANGE = 0;
const int RIGHT_RAHNGE = 10;

int[,] array = GetRandomMatrix (ROWS, COLUMNS, LEFT_RANGE, RIGHT_RAHNGE);
PrintMatrix(array);
Console.WriteLine();
int[,] array2 = GetRandomMatrix (ROWS, COLUMNS, LEFT_RANGE, RIGHT_RAHNGE);
PrintMatrix(array2);
Console.WriteLine();
int[,] resultArray = MultiplicationMatrix(array, array2);
PrintMatrix(resultArray);

