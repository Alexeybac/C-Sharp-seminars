int Nulloff(string text)
{
    Console.Write(text);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
int Summ( int x)
{
    if (x == 0)
    return 0;
    else
    return x + Summ(x-1);
    
}

// int N = Nulloff("Введите число:   ");
Console.Write($"-------- {Summ(Nulloff("Введите число:   "))} --------");