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
double [] RezMassiv (int [,] arr)
{
    double [] aray = new double [arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                sum += arr[i, j];
        aray[j] = Math.Round(sum/arr.GetLength(0), 2);
    }
    return aray;
}
void PrintRezult (double[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"({item,4}); ");
    }
}

int row = NullOff("Введите число строк массива: ");
int column = NullOff("Введите число столбцов массива: ");
int from = NullOff("Введите минимум элемента: ");
int to = NullOff("Введите максимум элемента: ");

int[,] mass = CreateMassiv(row, column, from, to);
Console.WriteLine("======Массив=====================");
PrintMassiv(mass);
Console.WriteLine("======Результат=================");
double [] rezMassiv = RezMassiv(mass);
PrintRezult(rezMassiv);
