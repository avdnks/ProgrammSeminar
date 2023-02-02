// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба 
// индекса чётные, и замените эти элементы на их квадраты.

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

void GetSquareElem (int[,] matrix)
{
    for (int i = 1; i < matrix.GetLength(0); i+= 2)
    {
        for (int j = 1; j < matrix.GetLength(1); j+= 2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
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

const int ROWS = 5;
const int COLUMNS = 4;
const int LEFT_RANGE = 0;
const int RIGHT_RAHNGE = 10;

int[,] resultMatrix = GetRandomMatrix (ROWS, COLUMNS, LEFT_RANGE, RIGHT_RAHNGE);
PrintMatrix(resultMatrix);
Console.WriteLine();
GetSquareElem(resultMatrix);
PrintMatrix(resultMatrix);