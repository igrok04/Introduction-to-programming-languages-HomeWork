/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
using static System.Console;

Clear();

Write("Введите N: ");
int N = int.Parse(ReadLine());

Write($"{N} -> ");

for (int i = 1; i <= N; i++)// для N > 1
{
    Write($"{i * i * i}, ");
}

for (int i = 1; i >= N; i--) // для N < 1
{
    Write($"{i * i * i}, ");
}
