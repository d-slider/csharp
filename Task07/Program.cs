﻿// Задача 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Clear();
Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = num;
if (num > 99 && num < 1000)
{
    Console.Write($"Последняя цифра числа: {num} = {num % 10}");
}
else
Console.Write("Вы ввели не трёхзначное число!");