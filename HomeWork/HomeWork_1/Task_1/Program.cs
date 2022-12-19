// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine ("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine ("Первое число большее, второе число меньшее");
}
else if (number1 < number2)
{
    Console.WriteLine ("Первое число меньшее, второе число большее");
}
else if (number1 == number2)
{
    Console.WriteLine ("Первое и второе числа равны");
}
