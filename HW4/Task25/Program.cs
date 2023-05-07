/*
Знакомство с языками программирования
Урок 7. Семинар. Функции: продолжение
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

using System;
using static System.Console;//использование функций класса консоль без вызова самого класса

Clear();

Write("Введите первое число A: ");
int numberA = int.Parse(ReadLine());

Write("Введите второе число B: ");
int numberB = int.Parse(ReadLine());

int result = 1;

if (numberA >= 1 && numberB >= 1)
{
    for (int i = 0; i < numberB; i++)
    {
        result *= numberA;
    }
    WriteLine($"Число {numberA} в степени {numberB} равно = {result}");
}
else
{
    WriteLine("Введено не натуральное число, дальнейшая работа программы не возможна!");
}
