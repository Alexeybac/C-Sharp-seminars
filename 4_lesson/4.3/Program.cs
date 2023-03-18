

int Sum (int N)  // Рекурсия:
{
    if (N == 0) return 1;
    return N * Sum(N-1);
}

Console.Write("Вводим число: ");
Console.Write(Sum(int.Parse(Console.ReadLine())));