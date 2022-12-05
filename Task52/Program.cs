// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int rows = ReadInt("Введите количество строк для создания массива: ");
int columns = ReadInt("Введите количество столбцов для создания массива: ");

int[,] numbers = new int[rows, columns];

double[] columnsAverage = new double[columns];

FillMatrixRandomNumbers(numbers);

for (int i = 0; i < numbers.GetLength(1); i++)
{
    double sum = 0; 
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        sum += numbers[j,i];
        columnsAverage[i] = Math.Round(sum/(numbers.GetLength(0)),2);
    }
}

WriteMatrix(numbers);

Console.WriteLine($"Среднее арифметическое каждого столбца: {String.Join("; ",columnsAverage)}");


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillMatrixRandomNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void WriteMatrix(int[,] array)
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