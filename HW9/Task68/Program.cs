/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29
*/
using System;
using static System.Console;

Clear();

int m = AskNumber("M");
int n = AskNumber("N");
WriteLine($"M = {m}; N = {n} -> A(m,n) = {Akerman(m, n)}");

int Akerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
        if ((n != 0) && (m == 0))
        return Akerman(n - 1, 1);
    else
        return Akerman(n - 1, Akerman(n, m - 1));
}

int AskNumber(string name)
{
    Write($"Введите число {name}: ");
    return int.Parse(ReadLine());
}
