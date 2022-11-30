// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

if (n < 0 || m < 0)
{
    Console.Write("Вы ввели отрицательное число!");
    return;
}
int result = FunctionAkkerman (m,n);

int FunctionAkkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
         return FunctionAkkerman(m - 1, 1);
    }
    else  if (m > 0 && n > 0)
    {
        return FunctionAkkerman(m - 1, FunctionAkkerman(m, n - 1));
    } 
    return n;
}
Console.WriteLine($" m = {m}, n = {n} -> A({m},{n}) = {result}");
