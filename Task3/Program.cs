// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;

int[,] numbers = new int[3, 4];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Average(int[,] massive)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            average += massive[i, j];
        }
        average = Math.Round(average / massive.GetLength(0), 1);
        Console.Write(average + "; ");
    }
}

FillArray(numbers);
PrintArray(numbers);
Average(numbers);
