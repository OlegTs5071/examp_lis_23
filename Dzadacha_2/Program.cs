﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


int numberA = Convert.ToInt32(Console.ReadLine()!);
int numberB = Convert.ToInt32(Console.ReadLine()!);
if (numberA > numberB)
{

    int max = numberA;
    Console.Write("max = " + max);
}
else
{
    int max = numberB;
    Console.Write("max = " + max);
}