/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

using System;
using static System.Console;

Clear();

Write("Введите число: ");
char[] array = ReadLine().ToCharArray();
var arrayValue = string.Join("", array);

if (array.Length <= 2)
{
    WriteLine("Третьей цифры нет!");
}
else
    WriteLine($"Третья цифра числа {arrayValue} = {array[2]}");