// Двумерный массив случайных чисел,
// найти сумму чисел, на нечетных позициях.

int[,] CreateMassiv(int x, int y)
{
    Console.WriteLine();
    int[,] aray = new int[x, y];
    for (int i = 0; i < aray.GetLength(0); i++)
    {
        for (int j = 0; j < aray.GetLength(1); j++)
        {
            aray[i, j] = new Random().Next(-100,100);
            Console.Write($"{aray[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return aray;
}

int SummNum (int[,] arr)
{
    int summ = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        if(i%2-1 != 0)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if(j%2-1 != 0) summ += arr[i,j];
            }
        }
    }
    return summ;
}

Console.Write("Зададим размер двумерного массива:  ");
int [,] mass = CreateMassiv(int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()));
Console.WriteLine($"{SummNum(mass)}");
