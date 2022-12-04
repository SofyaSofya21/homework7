﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int rows = 3;
int columns = 4;

int min = -9;
int max = 10;

double[,] numbers = new double[rows,columns];
FillMatrixRandomNumbers(numbers, min, max);

WriteMatrix(numbers);


void FillMatrixRandomNumbers(double[,] array, int minValue, int maxValue)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] =Math.Round((new Random().NextDouble()*(maxValue - minValue)+minValue),2);
        }
    }
}

void WriteMatrix(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



