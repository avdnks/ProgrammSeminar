// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange +1);
    }
    return array;
}

int[] massive = GetRandomArray(123, 0, 151);
Console.WriteLine(string.Join(", ", massive));

int Numbers = 0;
for (int i = 0; i < massive.Length; i++)
{
    if (massive[i] <= 99 && massive[i] >= 10)
    {
    Numbers += 1;
    }
}
Console.WriteLine($"Количество чисел в промежутке от 10 до 99: {Numbers}");