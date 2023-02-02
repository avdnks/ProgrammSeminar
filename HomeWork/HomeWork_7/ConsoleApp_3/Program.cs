// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

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

// double GetAverageColumns (int[,] matrix)
// {
//     double average = 0;
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             sum += matrix[i, j];
//         }
//         average = sum / matrix.GetLength(0);
//         Console.Write($"{average}");
//     }
//     return average;
// }

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

const int ROWS = 3;
const int COLUMNS = 4;
const int LEFT_RANGE = 0;
const int RIGHT_RAHNGE = 10;

int[,] array = GetRandomMatrix (ROWS, COLUMNS, LEFT_RANGE, RIGHT_RAHNGE);
PrintMatrix(array);
// int average = GetAverageColumns(array);
// Console.WriteLine($"Среднее равно: {average}");

double average = 0;
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    average = sum / array.GetLength(0);
    Console.Write($"{average:f2}" + " ");
}
