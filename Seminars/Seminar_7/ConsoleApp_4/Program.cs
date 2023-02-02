// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

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

int GetSumMainDiagonal (int[,] matrix)
{
    int result = 0;
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        result += matrix[i, i];
    }
    return result;
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

const int ROWS = 4;
const int COLUMNS = 3;
const int LEFT_RANGE = 0;
const int RIGHT_RAHNGE = 10;

int[,] array = GetRandomMatrix (ROWS, COLUMNS, LEFT_RANGE, RIGHT_RAHNGE);
PrintMatrix(array);
int sum = GetSumMainDiagonal(array);
Console.WriteLine($"Сумма равна: {sum}");
