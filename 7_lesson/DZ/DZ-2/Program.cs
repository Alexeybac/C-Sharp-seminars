// Принимает на вход позиции элемента в двумерном массиве,
// возвращает значение этого элемента
// или же, указание, что такого элемента нет.

Console.Clear();
int NullOff (string txt)
{
    Console.Write(txt);
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
void PrintMassiv (int [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
    Console.Write($"Строка № {i+1}: ");
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j], 4}");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int FindElement (int [,] arr, int i, int j)
{
    if (i-1 < arr.GetLength(0) && j-1 < arr.GetLength(1))
        Console.Write($"Искомый элемент [{i}, {j}] => ");
    else
    {
        Console.Write($"Элемента с координатами [{i}, {j}] в массиве нет.");
        Console.WriteLine();
        Console.WriteLine();
    }
    return arr[i-1,j-1];
}

int row = NullOff("Введите число строк массива: ");
int column = NullOff("Введите число столбцов массива: ");
int from = NullOff("Введите минимум элемента: ");
int to = NullOff("Введите максимум элемента: ");

int [,] mass = CreateMassiv(row, column, from, to);
Console.WriteLine("======Массив=====================");
PrintMassiv(mass);
Console.WriteLine(FindElement(mass,
                  NullOff("Введите номер строки элемента: "),
                  NullOff("Введите номер столбца элемента: ")));
Console.WriteLine();