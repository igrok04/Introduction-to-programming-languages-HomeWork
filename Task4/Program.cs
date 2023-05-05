//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

using System;
Console.Clear();
int max = 0;
Console.WriteLine("Введите первое число = ."); 
int FirstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число = .");
int SecondNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число = .");
int ThirdNum = Convert.ToInt32(Console.ReadLine());
if (FirstNum > SecondNum) max = FirstNum;
    else max = SecondNum;
        if (max > ThirdNum) max = SecondNum;
        else max = ThirdNum;

Console.WriteLine("Максимальное из трёх чисел = " + max);

