/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using System;
using static System.Console;//использование функций класса консоль без вызова самого класса

Clear();

Write("Введите натуральное число M: ");
int m = Convert.ToInt32(ReadLine());
Write("Введите натуральное число N, которое больше М: ");
int n = Convert.ToInt32(ReadLine());
WriteLine(PrintNumber(m, n));

WriteLine($"Сумма натуральных элементов в промежутке от {m} до {n} = {PrintSum(m, n)}");



//метод, который будет выводить все числа в строку
string PrintNumber(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumber(start + 1, end));
}

//метод, возвращающий сумму цифр числа
int PrintSum(int m, int n) {
    if(m > n) {
        return 0;
    }
    return m + PrintSum(m + 1, n);
}