//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка)

using System;
Console.Clear();
Console.Write("Введите число для проверки чётности = ");
int even = Convert.ToInt32(Console.ReadLine());
if (even % 2 == 0) Console.WriteLine("Чётное");
else 
Console.WriteLine("Нечётное");
