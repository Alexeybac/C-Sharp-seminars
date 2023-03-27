// Рекурсия выводит от M до N.

Console.Clear();
int NullOff(string txt)
{
    Console.Write(txt);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
void Nums(int N, int M)
{
    if (N < M) return;
    Nums(N - 1, M);
    Console.Write($"{N}, ");

}

void Num(int N, int M)
{
    if (M > N) return;
    Console.Write($"{M}, ");
    Num(N, M + 1);
}
int m = NullOff("Введите число M:  ");
int n = NullOff("Введите число N:  ");
Nums(n, m);