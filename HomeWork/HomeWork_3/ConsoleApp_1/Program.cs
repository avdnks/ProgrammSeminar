// Задача 19: Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

Console.WriteLine ("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 9999 || number > 100000)
{
    Console.WriteLine("Введенное число не является пятизначным");
    return;
}

string str = number.ToString();

if (str[0] == str[4] && str[1] == str[3])
{
    Console.WriteLine("Число является палиндромом");
}
else
{
    Console.WriteLine("Число не является палиндромом");
}


