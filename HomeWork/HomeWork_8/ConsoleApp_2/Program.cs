// Задача 56: Задайте двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

void NumberRowMinSum (int[,] matrix)
{
    int sum = 0;
    int row = 0;
    int minSumRow = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        minSumRow += matrix[0, j];
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) sum += matrix[i, j];
        if (sum < minSumRow)
        {
            minSumRow = sum;
            row = i;
        }
        sum = 0;    
    }
    Console.Write($"{row + 1} строка");
}

const int ROWS = 3;
const int COLUMNS = 4;
const int LEFT_RANGE = 0;
const int RIGHT_RAHNGE = 10;

int[,] array = GetRandomMatrix (ROWS, COLUMNS, LEFT_RANGE, RIGHT_RAHNGE);
PrintMatrix(array);
NumberRowMinSum (array);