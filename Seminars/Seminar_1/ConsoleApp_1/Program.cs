﻿// Напишите программу, которая на вход принимает 
// число и выдает его квадрат (число умноженное на само себя).

// Запрос числа от пользователя
Console.WriteLine ("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

// Квадрат введенного числа
int result = number * number;

// Вывод результата
Console.WriteLine ($"Квадрат введенного числа = {result}");

