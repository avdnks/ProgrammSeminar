// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 4 && number < 1)
{
    Console.WriteLine("Данной четверти не существует");
    return;
}
if (number == 1)
{
    Console.WriteLine("Диапазон возможных координат точек в этой четверти: x>0 y>0");
}
if (number == 2)
{
    Console.WriteLine("Диапазон возможных координат точек в этой четверти: x<0 y>0");
}
if (number == 3)
{
    Console.WriteLine("Диапазон возможных координат точек в этой четверти: x<0 y<0");
}
if (number == 4)
{
    Console.WriteLine("Диапазон возможных координат точек в этой четверти: x>0 y<0");
}

