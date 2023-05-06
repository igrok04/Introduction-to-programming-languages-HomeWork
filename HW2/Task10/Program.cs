/* 
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

using System;
using static System.Console;

Clear();

Write("Введите трехзначное число: ");
int number = Convert.ToInt32(ReadLine());
//int a1=number/10;
//int a2=a1%10;

//WriteLine($"{number} -> {a2}");
WriteLine($"{number} -> {(number / 10) % 10}");