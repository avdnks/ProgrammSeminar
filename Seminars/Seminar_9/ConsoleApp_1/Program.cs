// Задача 63: Задайте значение N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от 1 до N.

void PrintNaturalNumbers (int n)
{
    if (n == 0) return;
    PrintNaturalNumbers (n - 1);
    Console.Write(n + " ");
}

int number = 5;
PrintNaturalNumbers(number);