// № 10 Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine ("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int firstDigit = number / 10; 
    int secondDigit = firstDigit % 10;
    Console.WriteLine($"Вторая цифра числа {number}: {secondDigit}");
}
else
{
    Console.WriteLine("Введенное число не является трехзначным");
}



