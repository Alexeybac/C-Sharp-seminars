int NullOff(string text)
{
    Console.Write(text);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

void Mass (int x)
{
    Console.Write($"{x} => ");
    for(int i = 1; i <= x; i++)
    {
        Console.Write($"{Math.Pow(i,2)}, ");
    }
}

// int N = NullOff("Введите рандомную цифру: ");
Mass(NullOff("Введите рандомную цифру: "));