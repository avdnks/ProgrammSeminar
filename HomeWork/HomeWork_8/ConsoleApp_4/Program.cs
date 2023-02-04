// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] GetRandomMatrix (int leftRange, int rightRange)
{
    int[,,] matrix = new int [2, 2, 2];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = new Random().Next(leftRange, rightRange + 1);
            }
        }
    }
    return matrix;
}

void PrintMatrix (int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

const int LEFT_RANGE = 10;
const int RIGHT_RAHNGE = 100;

int[,,] array = GetRandomMatrix (LEFT_RANGE, RIGHT_RAHNGE);
PrintMatrix(array);
