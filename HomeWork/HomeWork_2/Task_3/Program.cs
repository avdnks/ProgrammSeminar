// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.WriteLine ("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7)
{
    Console.WriteLine ("Этот день выходной");
}
else if (number > 0 && number < 6)
{
    Console.WriteLine ("Этот день не выходной");
}
else 
{
    Console.WriteLine ("Такого дня недели нет");
}