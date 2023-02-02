// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter

// int positive = 0;
// while (Console.ReadKey().KeyChar != "stop")
// {
//     Console.WriteLine ("Введите число: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     if (n > 0)
//     {
//         positive += 1;
//     }
// }
// Console.WriteLine($"Положительных числ: {positive}");

int number;
int count = 0;
string? answer = null;
string stopWord = "stop";

while (true)
{
    answer = Console.ReadLine();
    if (answer == stopWord)
    {
        break;
    }
    number = Convert.ToInt32(answer);
    if (number > 0) count++;
}
Console.WriteLine($"Положительных числ: {count}");


