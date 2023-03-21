
int[] CreateMassiv(int size)
{
    int[] aray = new int[size];
    for (int i = 0; i < aray.Length; i++)
        aray[i] = new Random().Next(1, 10);
    return aray;
}
void PrintMassiv(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("] => ");
}

string FindNum(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return "Есть";
    }
    return "Нет";
}

Console.WriteLine("Введем размер рандомного массива и искомое число, построчно:  ");
int[] mass = CreateMassiv(int.Parse(Console.ReadLine()));
int num = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write($"{num}; Массив ");
PrintMassiv(mass);
Console.WriteLine(FindNum(mass, num));
Console.WriteLine();
