﻿Console.Clear();
int NullOff (string text)
{
    Console.Write(text);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
int[,] CreateMassiv(int row, int column, int from, int to)
{
    int[,] aray = new int[row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            aray[i, j] = new Random().Next(from, to);
    return aray;
}
void PrintAray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j], 5}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] NewMassiv(int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = i%2 != 0 && j%2 != 0 ? arr[i, j]*arr[i, j] : arr[i, j];
    }
    return arr;
}

int row = NullOff("Введите размеры массива (Строк): ");
int column = NullOff("Введите размеры массива (Столбцов): ");
int from = NullOff("Введите нижнюю границу рандомных чисел: ");
int to = NullOff("Введите верхнюю границу рандомных чисел: ");
Console.WriteLine("======Начало======");
int [,] mass = CreateMassiv(row, column, from, to);
PrintAray(mass);
Console.WriteLine("=====Результат======");
NewMassiv(mass);
PrintAray(mass);