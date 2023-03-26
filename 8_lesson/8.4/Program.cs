Console.Clear();
int Nulloff ( string txt)
{
    Console.Write(txt);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
int [,] CreateMassiv (int row, int column, int from, int to)
{
    int [,] aray = new int [row, column];
    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            aray[i, j] = new Random().Next(from, to);
    return aray;
}
void PrintAray (int [,] arr)
{
    Console.WriteLine("===Двумерный массив===");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j], 4}");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int [,] RezMass (int[,] arr)
{
    int [,] aray = new int[arr.GetLength(0)-1, arr.GetLength(1)-1];
    int min = arr[0,0], mini = 0, minj = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] < min)
                {
                min = arr[i, j];
                mini = i; 
                minj = j;
                }
            }
    Console.Write($" Удаляем: Строку => {mini+1}, Столбец => {minj+1}:");
    Console.WriteLine();
        for (int i = 0; i < aray.GetLength(0); i++)
            for (int j = 0; j < aray.GetLength(1); j++)
            {
                if (i < mini && j < minj) aray[i,j] = arr[i,j];
                if (i >= mini && j < minj) aray[i,j] = arr[i+1,j];
                if (i >= mini && j >= minj) aray[i,j] = arr[i+1,j+1];
                if (i < mini && j >= minj) aray[i,j] = arr[i,j+1];
            }
    return aray;
}

int row = Nulloff("Количество строк в массиве: ");
int column = Nulloff("Количество столбцов в массиве: ");
int from = Nulloff("Количество минимальное значение элемента: ");
int to = Nulloff("Количество максимальное значение элемента: ");

int [,] massiv = CreateMassiv(row, column, from, to);
PrintAray(massiv);
Console.WriteLine();
int [,] rezmassiv = RezMass(massiv);
PrintAray(rezmassiv);
