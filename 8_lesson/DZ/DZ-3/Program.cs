// Перемножение двух матриц.

Console.Clear();
int NullOff(string txt)
{
    Console.Write(txt);
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
void PrintMassiv(int[,] arr)
{
    Console.WriteLine("====Massiv========");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i, j],4}");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int [,] Rez (int [,] arrA, int [,] arrB)
{
    int [,] aray = new int [arrA.GetLength(0), arrB.GetLength(1)];
        for (int i = 0; i < arrB.GetLength(1); i++)
            for (int j = 0; j < arrA.GetLength(0); j++)
                for (int n = 0; n < arrB.GetLength(0); n++)
                    aray[j, i] += arrA[j, n] * arrB[n, i];
    return aray;
}


int row = NullOff("Введите кол-во строк массива: ");
int column = NullOff("Введите кол-во столбцов массива: ");
int from = NullOff("Введите нижний предел элементов: ");
int to = NullOff("Введите верхний предел элементов: ");
int [,] A = CreateMassiv(row+1, column, from, to);
int [,] B = CreateMassiv(row, column-1, from, to);
PrintMassiv(A);
PrintMassiv(B);
Console.WriteLine("=====Результат======");

int [,] rez = Rez(A, B);
PrintMassiv(rez);
