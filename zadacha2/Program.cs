﻿// Задача 2: Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Ввод чисел------
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
// Определение максимального числа-------
int max = Math.Max(a, b);
// Определение минимального числа-------
int min = Math.Min(a, b);
// Вывод результата-------
Console.WriteLine("Максимальное число: " + max);
Console.WriteLine("Минимальное число: " + min);
Console.ReadLine();