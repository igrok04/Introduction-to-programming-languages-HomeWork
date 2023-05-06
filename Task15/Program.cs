/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

using System;
using static System.Console;

Clear();

Write("Введите номер дня недели: ");
int number = Convert.ToInt32(ReadLine());

if (number > 0 && number < 6)
{
    WriteLine($"{number} -> нет");
}
else if (number == 6 || number == 7)
{
    WriteLine($"{number} -> да");
}
else
{
    WriteLine("Вы ввели неверное число. Введите число от 1 до 7");
}

