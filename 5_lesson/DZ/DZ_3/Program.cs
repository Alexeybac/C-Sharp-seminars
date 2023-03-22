// Задать одномерный массив случайных чисел,
// найти разницу между наксим и миним числами.

double[] CreateMassiv(int size)
{
    Console.WriteLine();
    Console.Write("МассиФФчиг => ");
    double[] aray = new double[size];
    for (int i = 0; i < size; i++)
    {
        aray[i] = Math.Round(new Random().NextDouble() * 22 - 10,2);
        Console.Write($"{aray[i]}, ");
    }
    Console.WriteLine();
    return aray;
}

double FindRez(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
    Console.WriteLine();
    return max - min;
}

Console.Write("Создадим массиФФчиг размером: ");
double[] mass = CreateMassiv(int.Parse(Console.ReadLine()));

double rezult = FindRez(mass);
Console.Write($"Разница макc и мин эл-ов =>  {Math.Round(rezult,2)}");
