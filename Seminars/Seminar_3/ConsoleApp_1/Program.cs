// №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите Х: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x == 0 || y == 0)
{
    Console.WriteLine("Точки не могу равняться 0");
    return;
}

if (x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой четверти");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во второй четверти");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей четверти");
}
if (x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвертой четверти");
}



