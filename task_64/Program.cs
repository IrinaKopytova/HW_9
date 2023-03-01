﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void PrintNumber(int number, int count)
{
    if (count > number)
    {
        return;
    }
    else
    {
        PrintNumber(number, count + 1);
        Console.Write(count + " ");
    }
}

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 1;
PrintNumber(N, count);


