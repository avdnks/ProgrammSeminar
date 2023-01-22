// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

int ReadNumber (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Numbers (int num)
{
    int index = 0;
    while (num > 0)
    {
        num = num / 10;
        index++;
    }
    return index;
}
int SumNumbers (int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum = sum + n % 10;
        n = n / 10;
    }
    return sum;
}

int number = ReadNumber("Введите число: ");
int length = Numbers (number);
int summa = SumNumbers (number, length);
Console.WriteLine(summa);
