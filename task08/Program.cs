﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 2) Console.Write("Тут нет чётных чисел");
int num1 = 2;
while (num1 <= num)
{
    Console.Write($"{num1}, ");
    num1 = num1 + 2;
}