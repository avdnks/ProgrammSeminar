// Задача 65: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N.

void PrintNaturalNumbers (int m, int n)
{
    if (n == m - 1) return;
    PrintNaturalNumbers (m, n - 1);
    Console.Write($"{n} ");
}

const int M = 3;
const int N = 10;

PrintNaturalNumbers(M, N);