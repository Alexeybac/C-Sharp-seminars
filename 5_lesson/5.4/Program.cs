
int[] CreateMassiv(int size)
{
    int[] array = new int[size];
    Console.Write("Свормирован рандомный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 5);
        Console.Write($"{array[i]}, ");
    }
    return array;
}

int[] RezMassiv(int[] arr)
{
    int[] summ = new int[arr.Length / 2 + arr.Length % 2]; // если arr массив нечетный
    for (int i = 0; i < arr.Length / 2; i++)
    {
        summ[i] = arr[i] * arr[(arr.Length - i) - 1];
    }
    if (summ[(arr.Length / 2 + arr.Length % 2) - 1] == 0)   // запол-м последн. индекс нечетного масива
        summ[(arr.Length / 2 + arr.Length % 2) - 1] = arr[(arr.Length / 2 + arr.Length % 2) - 1];
    return summ;
}

void PrintMass(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

Console.Write("Введите размер массива:  ");
int[] massiv = CreateMassiv(int.Parse(Console.ReadLine()));
Console.WriteLine();
int[] mass = RezMassiv(massiv);
Console.WriteLine();
Console.Write("Результирующий массив: =>  ");
PrintMass(mass);
Console.WriteLine();
