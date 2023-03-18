// Принимает на вход число N,
// выдает таблицу кубов от 1 до N.

int Nulloff (string text)
{
    Console.Write(text);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
void Cube (int n)
{
    Console.WriteLine();
    Console.Write($"Число {n} => ");
    double[] mass = new double[n];

    for (int i = 0; i < n; i++)
    {
        mass[i] = Math.Pow((i+1),3);
    }
    for (int i = 0; i < n; i++)
    {
        if(i == n-1)
        {
        Console.Write($"{mass[i]}. Конец!");
        Console.WriteLine();
        }
        else
        Console.Write($"{mass[i]}, ");
    }
}

Cube(Nulloff("Введите число :  "));
