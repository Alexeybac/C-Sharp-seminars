Console.Clear();

int NullOff (string text)
{
    Console.Write(text);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
int[,] CreateMassiv(int row, int column)
{
    int[,] aray = new int[row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            aray[i, j] = i + j;
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


int r = NullOff("Введите кол-во строк:    ");
int c = NullOff("Введите кол-во столбцов: ");

PrintAray(CreateMassiv(r, c));