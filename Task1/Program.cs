// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;

Console.WriteLine("Введите количетсво строк массива:");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количетсво столбцов массива:");
int column = int.Parse(Console.ReadLine());

double[,] numbers = new double[row, column];

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            double roundNumber = Math.Round(arr[i, j], 1);
            Console.Write(roundNumber + " ");
        }
        Console.WriteLine();
    }
}

FillArray(numbers);
PrintArray(numbers);
