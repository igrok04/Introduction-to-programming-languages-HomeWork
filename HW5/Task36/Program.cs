/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

using System;
using static System.Console;//использование функций класса консоль без вызова самого класса

Clear();

Write($"Введите длину массива: ");
int ElementNumbers = Convert.ToInt32(ReadLine()); 
//int randomNumber =  RandomNumbers(ElementNumbers, 0, 100);
WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {RandomNumbers(ElementNumbers, 0, 100)}");



int RandomNumbers(int ElementNumbers, int min, int max)
  {
  int[] randomNumber = new int[ElementNumbers];
  int sumElements = 0;
  Write("Получившийся массив: ");
    for (int i = 0; i <randomNumber.Length; i++ ){
      randomNumber[i] = new Random().Next(min, max);

      Write(randomNumber[i] + ", ");

      if (i % 2 != 1)
      {
        sumElements = sumElements + randomNumber[i];
      }
    }
  return sumElements;
  }