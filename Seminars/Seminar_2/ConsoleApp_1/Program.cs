// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

//Случайное число
int number = new Random().Next(10, 100);

//Первая цифра
int firstDigit = number / 10; 
//ВТорая цифра
int secondDigit = number % 10; 

Console.WriteLine($"Случайное число: {number}");

if (firstDigit > secondDigit)
{
    Console.WriteLine($"Наибольшая цифра числа: {firstDigit}");
}

if (secondDigit > firstDigit)
{
    Console.WriteLine($"Наибольшая цифра числа: {secondDigit}");
}

if (firstDigit == secondDigit)
{
    Console.WriteLine($"Цифры в числе равны");
}