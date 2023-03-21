
int[] CreateMassiv(int size) // Создали и напечатали рандомный массив!
{
    int[] aray = new int[size];
    for (int i = 0; i < aray.Length; i++)
    {
        aray[i] = new Random().Next(1, 123);
        Console.Write($"{aray[i]}, ");
    }
    return aray;
}
int FindNum(int[] arr)       // Посчитали, сколько элементов массива в пределах (10,99)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (10 <= arr[i] && arr[i] < 100) count ++;
    }
    return count;
}
Console.Write("Введем размер массива (123): => ");
int [] aray = CreateMassiv(int.Parse(Console.ReadLine()));
Console.WriteLine();
Console.Write($"==В массиве {FindNum(aray)} элементов от [10,99]!==");

