// Двумерный массив из целых чисел,
// найти средне-арифметическое элементов каждого столбца.

Console.Clear();
int NullOff(string txt)
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
void PrintMassiv(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"Строка № {i + 1,2}: ");
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j],4}");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] RevMassiv(int[,] arr)
{
    int[,] arr1 = new int[arr.GetLength(1), arr.GetLength(0)];
    for (int i = 0; i < arr1.GetLength(1); i++)
    {
        for (int j = 0; j < arr1.GetLength(0); j++)
            arr1[j, i] = arr[i, j];
    }
    return arr1;
}
double[] Rezult(int[,] arr)
{
    double sum = 0;
    double[] rezult = new double[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        rezult[i] = Math.Round(sum / arr.GetLength(1), 3);
    }
    return rezult;
}
void PrintRezult(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        if (i == arr.Length-1) Console.Write($"({arr[i]}).");
        else Console.Write($"({arr[i]});  ");
    Console.WriteLine();
}

int row = NullOff("Введите число строк массива: ");
int column = NullOff("Введите число столбцов массива: ");
int from = NullOff("Введите минимум элемента: ");
int to = NullOff("Введите максимум элемента: ");

int[,] mass = CreateMassiv(row, column, from, to);
Console.WriteLine("======Массив=====================");
PrintMassiv(mass);
Console.WriteLine("======Результат=================");
int[,] rez = RevMassiv(mass);
double[] rezult = Rezult(rez);
PrintRezult(rezult);
Console.WriteLine();