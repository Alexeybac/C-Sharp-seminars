﻿Console.Clear();
int Nulloff ( string txt)
{
    Console.Write(txt);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
int [,] CreateMassiv (int row, int column, int from, int to)
{
    int [,] aray = new int [row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            aray[i, j] = new Random().Next(from, to);
    return aray;
}
void PrintAray (int [,] arr)
{
    Console.WriteLine("===Двумерный массив===");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j], 4}");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void RevMassiv (int [,] arr)
{
    int i = arr.GetLength(0);
    for (int j = 0; j < arr.GetLength(1); j++)
        (arr[i-1,j], arr[0,j]) = (arr[0,j], arr[i-1,j]);
}

int row = Nulloff("Количество строк в массиве: ");
int column = Nulloff("Количество столбцов в массиве: ");
int from = Nulloff("Количество минимальное значение элемента: ");
int to = Nulloff("Количество максимальное значение элемента: ");

int [,] massiv = CreateMassiv(row, column, from, to);
PrintAray(massiv);
RevMassiv(massiv);
Console.WriteLine("--Переворот--");
// Console.WriteLine();
PrintAray(massiv);