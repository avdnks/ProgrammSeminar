// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

int[] Fibonachi (int size)
{
    int[] array = new int[size];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2]; 
    }
    return array;
}
int[] massive = Fibonachi(7);
Console.WriteLine(string.Join(" ,", massive));