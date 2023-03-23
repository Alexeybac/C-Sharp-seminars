
int[,] CreateAray()
{
    Console.WriteLine("Введите размер двумерного массива (строк/столбцов); ");
    int str = int.Parse(Console.ReadLine());
    int column = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите диапазон числе в массиве (от/до); ");
    int from = int.Parse(Console.ReadLine());
    int to = int.Parse(Console.ReadLine());
    int[,] aray = new int[str, column];
    for (int i = 0; i < str; i++)
    {
        for (int j = 0; j < column; j++)
            aray[i, j] = new Random().Next(from, to);
    }
    return aray;
}
void PrintAray(int[,] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j]}  ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] CopyAray(int[,] arr)
{
    int a = arr.GetLength(0), b = arr.GetLength(1);
    int[,] arr2 = new int[a, b];

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
            arr2[i, j] = arr[i, j];
    }
    return arr2;
}

// Console.WriteLine("Введите размер двумерного массива (строк/столбцов); ");
// int str = int.Parse(Console.ReadLine());
// int column = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите диапазон числе в массиве (от/до); ");
// int from = int.Parse(Console.ReadLine());
// int to = int.Parse(Console.ReadLine());

int[,] massiv = CreateAray();
PrintAray(massiv);
Console.WriteLine();
int[,] revMassiv = CopyAray(massiv);
PrintAray(revMassiv);


