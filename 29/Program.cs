﻿/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] arr = new int[8];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.Next();
}

Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{

    Console.Write(arr[i] + " ");
}

Console.Write("]");