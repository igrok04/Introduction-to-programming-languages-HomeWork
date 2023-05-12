/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

и

1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/
using System;
using static System.Console;//использование функций класса консоль без вызова самого класса

Clear();

Write("Введите количество столбцов (Первой) матрицы и строк (Второй) матрицы: ");
int columnRows = int.Parse(ReadLine());

Write("Введите количество строк (Первой) матрицы: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов (Второй) матрицы: ");
int columns = int.Parse(ReadLine());

/// Метод создания двумерного массива
int[,] GetArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random randomValue = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomValue.Next(0, 10);
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

/// Метод нахождения произведения двух матриц
int[,] ArrayMultiply(int[,] arrayFirst, int[,] arraySecond)
{
    int arrayMult = 0;
    int[,] arrayThird = new int[arrayFirst.GetLength(0), arraySecond.GetLength(1)];
    for (int i = 0; i < arrayFirst.GetLength(0); i++)
    {
        for (int j = 0; j < arraySecond.GetLength(1); j++)
        {
            arrayMult = (arrayFirst[i, j] * arraySecond[i, j]);
            arrayThird[i, j] = arrayMult;
            arrayMult = 0;
        }
    }
    return arrayThird;
}

int[,] firstArray = GetArray(rows, columnRows);
int[,] secondArray = GetArray(columnRows, columns);

WriteLine($"(Первая) матрица. Строк = ({rows}), столбцов = ({columnRows}):");
PrintArray(firstArray);
WriteLine();
WriteLine($"(Вторая) матрица. Строк = ({columnRows}), столбцов = ({columns}):");
PrintArray(secondArray);
int[,] thirdArray = ArrayMultiply(firstArray, secondArray);
WriteLine();
WriteLine($"Произведение матриц. Строк = ({rows}), столбцов = ({columns}):");
PrintArray(thirdArray);