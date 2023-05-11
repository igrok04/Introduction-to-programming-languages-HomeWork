/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 

этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/
using System;
using static System.Console;//использование функций класса консоль без вызова самого класса

Clear();

Write("Введите номер строки массива: ");
int userRow = int.Parse(ReadLine());

Write("Введите номер столбца массива: ");
int userColumn = int.Parse(ReadLine());


/// Создание случайного двумерного массива
int [,] GetArray(int rows, int columns)
{
    int [,] array = new int[rows, columns];
    Random arrayRandomValue = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = arrayRandomValue.Next(1, 10);
                }
            }
    return array;
}

/// Метод печати массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

        {
            Write("{0,6}", array[i, j]);
        }
        WriteLine();
    }
}

int [,] array = GetArray(3, 4);

/// Метод поиска элемента массива
void SearchArrayIndex (int userRow, int userColumn)
{
    if (userRow <= array.GetLength(0) - 1 && userColumn <= array.GetLength(1) - 1)
        WriteLine($"Значение элемента в позиции [{userRow},{userColumn}] = {array[userRow,userColumn]}");
    else if (userRow > array.GetLength(0) - 1 || userColumn > array.GetLength(1) - 1)
        WriteLine($"Элемента [{userRow},{userColumn}] нет в заданном двумерном массиве");
}



PrintArray(array);
SearchArrayIndex(userRow, userColumn);