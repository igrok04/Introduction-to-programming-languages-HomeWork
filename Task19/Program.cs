/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

using System;
using static System.Console;

Clear();

Write("Введите пятизначное число: ");
char[] array = ReadLine().ToArray();
var arrayValue = string.Join("", array);

if (array.Length > 4 && array.Length < 6)

{
        if (array[0] == array[4] && array[1] == array[3])
        {
            
            WriteLine($"Число {arrayValue} является палиндромом!");
        }
        else
        {
            WriteLine($"Число {arrayValue} не является палиндромом!");
        }
}
else
{
    WriteLine($"Число {arrayValue} состоит не из 5 символов. Соберитесь с силами и введите пятизначное число!");
}
