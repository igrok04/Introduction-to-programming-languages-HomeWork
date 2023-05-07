/*
Знакомство с языками программирования
Урок 7. Семинар. Функции: продолжение
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
using System;
using static System.Console;
Clear();

int[] ar = AskNumbers();
WriteLine($"Вы ввели числа: {String.Join(",", ar)} -> получили массив [{String.Join(",", ar)}]");

int[] AskNumbers() {
    int[] ar = new int[8];
    for(int i = 0; i < ar.Length; i++) {
        ar[i] = AskNumber(i + 1);
    }
    return ar;
}

int AskNumber(int i) {
     Write($"Введите число {i}: ");
     return int.Parse(ReadLine());
}

