// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int num = Convert.ToInt32(Console.ReadLine());
string b = "";
string k = "";

while(num > 0)
{
    k = Convert.ToString(num % 2);
    b = k + b;
    num = num / 2;
}
Console.WriteLine(b);



