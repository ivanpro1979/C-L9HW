// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

if (n < 1 || m < 1)
{
    Console.Write("Вы ввели не натуральное число!");
    return;
}
if (n < m)
{
    Console.Write("Вы ввели недопустимые по заданию значения, N меньше M!");
    return;
}
int sum = 0;
PrintNumSum(m, n);

void PrintNumSum(int start, int end)
{
    sum += start;
    if (start == end) return;
    PrintNumSum(start + 1, end);
}
Console.Write($"{m}; {n} -> {sum} ");

// Подскажите пожалуйста, почему ниже приведенный метод не работает?

// void PrintNumSum(int start, int end)
// {
//     int sum = 0;
//     sum += start;
//     if (start == end) Console.Write($"{m}; {n} -> {sum} ") return;
//     PrintNumSum(start + 1, end);
// }