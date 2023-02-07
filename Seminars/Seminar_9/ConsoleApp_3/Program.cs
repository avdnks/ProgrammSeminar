// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int SumOfDigit (int number)
{
    int sum = 0;
    if (number / 10 == 0) return number % 10;
    return sum += number % 10 + SumOfDigit(number / 10);
}

const int number = 4535;
Console.Write(SumOfDigit(number));