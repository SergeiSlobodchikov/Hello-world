﻿//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
Console.Write("Введите число: ");
int i = Math.Abs((Convert.ToInt32(Console.ReadLine())));
int minusi = (i*(-1));
for ( ; minusi <= i; minusi++)
{
    Console.Write(minusi+" ");
}

    
