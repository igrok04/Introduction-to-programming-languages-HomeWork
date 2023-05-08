/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

using System;
using static System.Console;//использование функций класса консоль без вызова самого класса

Clear();

Write("Введите длину массива:  ");
int size = Convert.ToInt32(ReadLine());
double[] number = new double[size];

FillArrayRandomNumbers(number);
WriteLine($"Массив: [{String.Join(" ",number)}]");


double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int a = 0; a < number.Length; a++)
{
    if (number[a] > max)
    {
        max = number[a];
    }
    if (number[a] < min)
    {
        min = number[a];
    }
}

WriteLine($"Всего в массиве {number.Length} чисел. Максимальное = {max}, Минимальное = {min}");
WriteLine($"Разность между максимальным и минимальным = {max - min:f2}");

void FillArrayRandomNumbers(double[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}
void PrintArray(double[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        Write(number[i] + " ");
    }
    WriteLine();
}
