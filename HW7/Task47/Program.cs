/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

using System;
using static System.Console;//использование функций класса консоль без вызова самого класса

Clear();
Write("Введите колличество строк массива: ");
int m = int.Parse(ReadLine());

Write("Введите колличество столбцов массива: ");
int n = int.Parse(ReadLine());

double[,] array = GetArray(m, n);
WriteLine("Массив случайных вещественных чисел: ");
PrintArray(array);

// Рандомный двумерный массив
double[,] GetArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 10;
        }
    }
    return array;
}

// Метод печати массива
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            Write("{0,8}", Math.Round(array[i, j], 2));
        }
        WriteLine();
    }
}

