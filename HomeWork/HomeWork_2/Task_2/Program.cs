// №13 Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int thirdDigit = 0;

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}

while (number > 1000)
 {
    number = number / 10;
 }

thirdDigit = number % 10;
Console.WriteLine($"Третья цифра: {thirdDigit}");
