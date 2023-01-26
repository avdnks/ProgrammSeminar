// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

int [] array = {6,7,3,6};
// int size = (array.Length + 1) / 2;
int size;
if (array.Length % 2 == 0)
{
    size = array.Length / 2;
}
else 
{
    size = array.Length / 2 + 1;
}

int [] newArray = new int[size];
for (int i = 0; i < newArray.Length; i++)
{
    newArray[i] = array[i] * array[array.Length - 1 - i];
}

if (array.Length % 2 == 1)
{
    newArray[size - 1] = array[array.Length / 2];
}
Console.WriteLine(string.Join(", ", newArray));