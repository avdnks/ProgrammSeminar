// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange +1);
    }
    return array;
}

int[] massive = GetRandomArray(12, -9, 9);
Console.WriteLine(string.Join(", ", massive));
int sumP = 0;
int sumN = 0;

for(int i = 0; i < massive.Length; i++)
{
    if (massive[i] > 0)
    {
        sumP += massive[i];
    }
    else
    {
        sumN += massive[i];
    }
}
Console.WriteLine($"Сумма положительных элементов равна = {sumP}");
Console.WriteLine($"Сумма отрицательных элементов равна = {sumN}");
