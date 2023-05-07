/*
Знакомство с языками программирования
Урок 7. Семинар. Функции: продолжение
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
using System;
using static System.Console;//использование функций класса консоль без вызова самого класса

Clear();

Write("Введите число, для вычисления суммы всех его цифр: ");

int result = 0;
string number = ReadLine();
char[] array = number.ToCharArray();
int[] arrayResult = new int[number.Length];

for (int i = 0; i < array.Length; i++)
{
    arrayResult[i] = int.Parse(array[i].ToString());
    result += arrayResult[i];
}

var arrayValue = string.Join(" + ", arrayResult);

Console.WriteLine($"Сумма всех цифр числа: {number}: {arrayValue} = {result}");
