// Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.

int first2 = 0;
int second2 = 0;

Console.WriteLine ("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
if (first < 0) {first2 = first * (-1);}
else first2 = first;

Console.WriteLine ("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());
if (second < 0) {second2 = second * (-1);}
else second2 = second;

if (Math.Sqrt(first2) == second2)
{
    Console.WriteLine($"Число {first2} является квадратом {second2}");
}
else if (Math.Sqrt(second2) == first2)
{
    Console.WriteLine($"Число {second2} является квадратом {first2}");
}
else Console.WriteLine($"Числа {first2} и {second2} не являются квадратами друг друга");