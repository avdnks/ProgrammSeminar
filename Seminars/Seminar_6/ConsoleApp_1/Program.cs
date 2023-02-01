// Задача 39

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange +1);
    }
    return array;
}

void Reverse(int[] sourceArray)
{
    for (int i = 0; i < sourceArray.Length / 2; i++)
    {
        int temp = sourceArray[i];
        sourceArray[i] = sourceArray[sourceArray.Length - i - 1];
        sourceArray[sourceArray.Length - i - 1] = temp;
    }
}

const int size = 6;
const int leftRange = -9;
const int rightRange = 9;
int[] massive = GetRandomArray(size, leftRange, rightRange);
Console.WriteLine(string.Join(", ", massive));
Reverse(massive);
Console.WriteLine(string.Join(", ", massive));
