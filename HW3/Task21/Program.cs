/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
using System;
using static System.Console;

Clear();

Write("Введите координату X1: ");
int x1 = int.Parse(ReadLine());
Write("Введите координату Y1: ");
int y1 = int.Parse(ReadLine());
Write("Введите координату Z1: ");
int z1 = int.Parse(ReadLine());

Write("Введите координату X2: ");
int x2 = int.Parse(ReadLine());
Write("Введите координату Y2: ");
int y2 = int.Parse(ReadLine());
Write("Введите координату Z2: ");
int z2 = int.Parse(ReadLine());

double d = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
WriteLine($"Расстояние между точками = {d:f2}");