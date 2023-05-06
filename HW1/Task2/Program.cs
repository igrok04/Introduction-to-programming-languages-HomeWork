//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

using System;
Console.Clear();
Console.WriteLine("Введите первое число: "); 
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
if (FirstNumber > SecondNumber)
{
    Console.WriteLine("Первое число больше = " + FirstNumber);
} 
else if (FirstNumber < SecondNumber)
{
    Console.WriteLine("Второе число больше = " + SecondNumber);
}
else
{
    Console.WriteLine("Числа равны = " + SecondNumber + "=" + FirstNumber);
}

