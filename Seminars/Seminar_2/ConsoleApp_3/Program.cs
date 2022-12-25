// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

Console.WriteLine ("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == 0)
{
    Console.WriteLine("Второе число не может быть нулем");
}
else 
{
    int rest = number1 % number2;
    if (rest == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine($"Не кратно, остаток {rest}");
    }
}


