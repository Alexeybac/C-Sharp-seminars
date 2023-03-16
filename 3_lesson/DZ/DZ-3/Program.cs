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
    Console.Write($"Число {n} => ");
    for (int i = 1; i <= n; i++)
    {
        if (i == n) Console.Write($"{i*i*i}. ");
        else
        Console.Write($"{i*i*i}, ");
    }
}

Cube(Nulloff("Введите число :  "));
