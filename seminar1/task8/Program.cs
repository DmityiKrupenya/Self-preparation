﻿// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= N; i += 1)
{
    if(i % 2 == 1)
    Console.WriteLine(i + 1);
}


                