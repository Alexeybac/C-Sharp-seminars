// Задайте двумерный массив размером MxN,
// с случайными вещественными числами.

Console.Clear();
int NullOff (string txt)
{
    Console.Write(txt);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
double[,] CreateMassiv(int row, int column, int from, int to)
{
    double[,] aray = new double[row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
        aray[i, j] = Math.Round(new Random().NextDouble() * (from + to) - to, 2);
    return aray;
}
void PrintMassiv (double [,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j], 7}");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int row = NullOff("Введите число строк массива:");
int column = NullOff("Введите число столбцов массива:");
int from = NullOff("Введите минимум элемента:");
int to = NullOff("Введите максимум элемента:");

double [,] mass = CreateMassiv(row, column, from, to);
Console.WriteLine("==Массив=====================");
PrintMassiv(mass);