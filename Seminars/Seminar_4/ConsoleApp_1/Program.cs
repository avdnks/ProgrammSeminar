// Задача 24: Напишите программу, которая принимает 
// на вход число (А) и выдаёт сумму чисел от 1 до А.

int ReadNumber (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSum1ToA (int a)
{
    int sum = 0;
    for (int i = 0; i <= a; i++)
    {
        sum += i;
        // sum = sum + 1
    }
    return sum;
}

int number = ReadNumber("Напишите число: ");
if (number > 0)
{
    int summa = GetSum1ToA (number);
    Console.WriteLine(summa);
}
else
{
    Console.WriteLine("Введено неверное число");
}