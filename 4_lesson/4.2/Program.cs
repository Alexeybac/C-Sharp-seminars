
int Nul (string t)
{
    Console.Write(t);
    var s = Console.ReadLine();
    int a = s == null ? 0: int.Parse(s);
    return a;
}

int Num (int N)   // Вариант через строку:
{
    string x = N.ToString();
    int leng = x.Length;
    return leng;
}

int Number (int N) // Вариант через цифры:
{
    int count = 0;
    while (N > 0)
    {
    count = count + 1;
    N /=10;
    }
    return count;
}

Console.WriteLine(Num(Nul("Введите число:  ")));
Console.WriteLine(Number(Nul("Введите число:  ")));