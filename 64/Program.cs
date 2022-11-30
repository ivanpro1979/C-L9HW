﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.Clear();
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());
if (n < 1)
{
    Console.Write("Вы ввели не натуральное число!");
    return;
}

PrintNumbers(n, 1);

void PrintNumbers(int start, int end)
{
    Console.Write($"{start} ");
    if (start == end) return;
    PrintNumbers(start - 1, end);
}