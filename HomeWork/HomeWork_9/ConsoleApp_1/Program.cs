﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1.

void PrintNaturalNumbersToLow (int n, int count)
{
    if (count > n) return;
    PrintNaturalNumbersToLow (n, count + 1);
    Console.Write(count + " ");
}

int number = 5;
int count = 1;
PrintNaturalNumbersToLow(number, count);
