﻿/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int Result = 0; 

for (int i = 0; i<=a; i++)
{
Result = Result + a%10;
a = a/10; 
}

Console.WriteLine(Result);