// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.

int SumMN (int m, int n)
{
    int sum = 0;
    if (m == n) return n;
    sum += m + SumMN(m + 1, n);
    return sum;
}

const int M = 1;
const int N = 15;
Console.Write(SumMN(M, N));