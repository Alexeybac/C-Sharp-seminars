
int[] CreateMass(int size, int num)    // Создаем массив
{
    int[] aray = new int[size];
    for (int i = 0; i < size; i++)
    {
        aray[i] = new Random().Next(-num, num);
    }
    return aray;
}
void PrintMass(int[] arr)              // Печатаем массив
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine();
}

int[] UnMass(int[] arr)               // Переворот исходного массива
{
    // int[] arr1 = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0) arr[i] = -arr[i];
        else
            arr[i] = -arr[i];
    }
    return arr;
}

Console.WriteLine("Введите, построчно, размер массива и его размах (от -А до +А): ");
int[] mass = CreateMass(int.Parse(Console.ReadLine()),
                         int.Parse(Console.ReadLine()));
Console.Write("Исходник =>    Исходный массив:       ");
PrintMass(mass);
Console.WriteLine();
// UnMass(mass);
Console.Write("Результат =>   Перевернутый массив:   ");
PrintMass(UnMass(mass));