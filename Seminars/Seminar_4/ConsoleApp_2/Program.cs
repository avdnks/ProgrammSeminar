// Задача 26: Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.

int ReadNumber (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Numbers (int num)
{
    int count = 0;
    while (num != 0)
    {
        count++;
        num = num / 10;
    }
    return count;
}

int number = ReadNumber("Введите число: ");
int CountOfNumbers = Numbers (number);
Console.WriteLine(CountOfNumbers);