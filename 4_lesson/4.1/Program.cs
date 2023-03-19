
int Nulloff(string x)
{
    Console.Write(x);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
int X (int N)
{
    if (N == 0) return 1;
    else
    return N * X(N-1);
}

Console.WriteLine(X(Nulloff("Введите число:  ")));