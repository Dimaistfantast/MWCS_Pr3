﻿Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= number; i++) 
{
    int kvadra = i * i;
    Console.Write($"{kvadra}, ");
}