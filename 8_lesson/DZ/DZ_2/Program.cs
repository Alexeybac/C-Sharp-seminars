// Создать прямоугольный двумерный массив,
// найти строку с наименьшей суммой элементов.

Console.Clear();
int NullOff(string txt)
{
    Console.Write(txt);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
int[,] CreateMassiv(int row, int from, int to)
{
    int[,] aray = new int[row, row + 3];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < row + 3; j++)
            aray[i, j] = new Random().Next(from, to);
    return aray;
}
void PrintMassiv(int[,] arr)
{
    Console.WriteLine("====Massiv========");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write($"Строка {i+1}: =>   ");
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j],4}");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int MinSumm(int[,] arr)
{
    int[] sumRows = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++) sum += arr[i, j];
        sumRows[i] = sum;
    }
    int indexMin = 0;
    for (int i = 0; i < sumRows.Length-1; i++)
        if (sumRows[i+1] < sumRows[indexMin]) indexMin = i + 1;
    return indexMin;
}

int[,] massiv = CreateMassiv(NullOff("Введите кол-во строк массива:"),
                            NullOff("Введите нижний предел элементов:"),
                            NullOff("Введите верхний предел элементов:"));
PrintMassiv(massiv);
Console.WriteLine("===Результат=======");
Console.WriteLine($"Строка с наименьшей суммой в массиве: {MinSumm(massiv) + 1}.");