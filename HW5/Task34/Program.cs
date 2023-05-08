/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

using System;
using static System.Console;//использование функций класса консоль без вызова самого класса

Clear();

int[] array = GetArray(4, 100, 1000);
WriteLine($"Массив: [{String.Join(", ", array)}]");
//int countElements = GetCountElements(array, 100, 999);
WriteLine($"Количество чётных чисел в массиве = {GetCountElements(array, 100, 999)}");


int GetCountElements(int[] inArray, int leftRange, int rigthRange)//метод, который вернет количество элементов, 
//находящихся в заданном диапазоне
{
    int count = 0;
    foreach (int item in inArray)
    {
        if (item % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] GetArray(int size, int min, int max)//метод, формирующий массив
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}
