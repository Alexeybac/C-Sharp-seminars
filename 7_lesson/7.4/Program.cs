Console.Clear();
int NullOff (string text)
{
    Console.Write(text);
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
void PrintAray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j], 5}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
string FindNum(int [,] arr, int num)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            if (arr[i, j] == num) 
            return $"Элемент {num} есть: [строка=> {i+1}, столбец => {j+1}].";
    }
return $"Элемента {num} в заданном массиве нет!";
}

int row = NullOff("Введите размеры массива (Строк): ");
int column = NullOff("Введите размеры массива (Столбцов): ");
int from = NullOff("Введите нижнюю границу рандомных чисел: ");
int to = NullOff("Введите верхнюю границу рандомных чисел: ");
Console.Clear();
Console.WriteLine("======Массив======");
int [,] mass = CreateMassiv(row, column, from, to);
PrintAray(mass);
Console.WriteLine("======Результат======");
Console.WriteLine(FindNum(mass, NullOff("Введите искомый элемент N: ")));
