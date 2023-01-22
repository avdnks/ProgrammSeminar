// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

int ReadNumber (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Degree (int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}

int numberA = ReadNumber("Введите число: ");
int numberB = ReadNumber("Введите степень: ");

int summa = Degree (numberA, numberB);
Console.WriteLine(summa);