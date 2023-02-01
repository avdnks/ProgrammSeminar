// Задача 40.

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

bool Treangle (int x, int y, int z)
{
    if (x+y>z && x+z>y && y+z>x)
    {
        return true;
    }
    return false;
}

Console.WriteLine($"Такой треугольник существует: {Treangle(a, b, c)}");