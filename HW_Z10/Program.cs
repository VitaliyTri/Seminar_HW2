﻿//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


int number = new Random().Next(100, 1000);
int firstnumber = number % 100;
int secondnumber = firstnumber / 10;

Console.WriteLine($"Вторая цифра числа {number} - {secondnumber}");