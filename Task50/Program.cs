// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int rows = ReadInt("Введите количество строк для создания массива: ");
int columns = ReadInt("Введите количество столбцов для создания массива: ");

int findRow = ReadInt("Введите номер строки искомого элемента: ");
int findColumn = ReadInt("Введите номер столбца искомого элемента: ");

findRow--; // т.к. массивы начинают счет с 0
findColumn--; // т.к. массивы начинают счет с 0

int[,] numbers = new int[rows, columns];
FillMatrixRandomNumbers(numbers);

WriteMatrix(numbers);

if (findRow > rows || findColumn > columns)
    Console.WriteLine("Элемента с заданными координатами в массиве не существует.");
else
    Console.WriteLine($"Число с координатами ({findRow+1},{findColumn+1}) -> {numbers[findRow,findColumn]}");



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



