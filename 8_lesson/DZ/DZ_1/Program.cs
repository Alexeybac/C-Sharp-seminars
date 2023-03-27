// Упорядочит по убыванию элементы 
// каждой строки двумерного массива.
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
    Console.WriteLine("====Massiv========");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j],4}");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] SortMassiv(int[,] arr)
{
    for (int n = 0; n < arr.GetLength(0); n++)
    {
        for (int i = 0; i < arr.GetLength(1) - 1; i++)
        {
            int indexMax = i;
            for (int j = i + 1; j < arr.GetLength(1); j++)
            {
                if (arr[n, j] > arr[n, indexMax]) indexMax = j;
            }
            (arr[n, i], arr[n, indexMax]) = (arr[n, indexMax], arr[n, i]);
        }
    }
    return arr;
}

int[,] massiv = CreateMassiv(NullOff("Введите кол-во строк массива:"),
             NullOff("Введите кол-во столбцов массива:"),
             NullOff("Введите нижний предел элементов:"),
             NullOff("Введите верхний предел элементов:"));

PrintMassiv(massiv);
Console.WriteLine("===Результат=======");
PrintMassiv(SortMassiv(massiv));
Console.ReadKey();
