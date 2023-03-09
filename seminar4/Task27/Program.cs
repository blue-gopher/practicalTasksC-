﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfDigit(int num) 
{
    int sum = 0;
    while (num > 0) 
    {   
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of digits = {SumOfDigit(num)}");

