Console.Clear();
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
void PrintMassiv (int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.WriteLine($"{i} встречается {arr[i]} раз. ");
    Console.WriteLine();
}
int [] FrequencyDict (int [,] arr)
{
    int [] freq = new int[10];
        foreach (var i in arr)
            freq[i] += 1;
    return freq;
}
int Nulloff ( string txt)
{
    Console.Write(txt);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

int row = Nulloff("Количество строк в массиве: ");
int column = Nulloff("Количество столбцов в массиве: ");
int from = Nulloff("Количество минимальное значение элемента: ");
int to = Nulloff("Количество максимальное значение элемента: ");

int [,] massiv = CreateMassiv(row, column, from, to);
PrintAray(massiv);
int [] rezult = FrequencyDict(massiv);
PrintMassiv(rezult);