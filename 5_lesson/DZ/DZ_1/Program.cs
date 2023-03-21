
// Массив, заполненный случайными трехзначными числами.
// Прога показывает количество четных числе в массиве.

int[,] CreateMassiv(int x, int y)
{
    Console.WriteLine();
    int[,] aray = new int[x, y];
    for (int i = 0; i < aray.GetLength(0); i++)
    {
        for (int j = 0; j < aray.GetLength(1); j++)
        {
            aray[i, j] = new Random().Next(100, 1000);
            Console.Write($"{aray[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return aray;
}

int CountTwise(int[,] arr)
{
    int count = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] % 2 == 0) count++;
        }
    }
    return count;
}


Console.WriteLine("Введите размер двузначного массива:  ");
int[,] mass = CreateMassiv(int.Parse(Console.ReadLine()),
                           int.Parse(Console.ReadLine()));
Console.WriteLine($"Количество четных чисел в массиве = {CountTwise(mass)}");
Console.WriteLine();
