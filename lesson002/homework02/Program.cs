﻿// Задача 2:
// Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого числа.
// 645 -> 65
// 782 -> 72
// 918 -> 98

int a = new Random().Next(100, 999);
Console.WriteLine(a);
Console.WriteLine(a / 100 * 10 + a % 10);

