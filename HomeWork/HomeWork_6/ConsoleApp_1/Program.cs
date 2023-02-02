// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter

int positive = 0;
while (Console.ReadKey().KeyChar != "stop")
{
    Console.WriteLine ("Введите число: ");
    int n = Convert.ToInt32(Console.ReadLine());
    if (n > 0)
    {
        positive += 1;
    }
}
Console.WriteLine($"Положительных числ: {positive}");

