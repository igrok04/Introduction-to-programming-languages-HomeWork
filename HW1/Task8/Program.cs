//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

using System;
Console.Clear();
Console.Write("Введите число больше или равно 1: ");
int N = Convert.ToInt32(Console.ReadLine());
int B = 1;
Console.Write($"Четные числа от 1 до {N}: ");
while (B <= N)
{
    if (N == 1)
    {
        Console.Write("отсутствуют");
    }
    if (B % 2 == 0)
    {
        Console.Write($"{B} ");
    }
    B++;
}


