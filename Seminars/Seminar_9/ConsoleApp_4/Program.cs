// Задача 69: Напишите программу, которая на вход принимает 
// два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

int GetPow (int a, int b)
{
    int pow = 1;
    if  (b == 0) return 1;
    return pow *= a * GetPow(a, b - 1);
}

const int A = 2;
const int B = 4;

Console.Write(GetPow(A, B));

