// Задайте значения M и N, 
// выводит все четные натуральные числа в промежутке от M до N,
// с помощью рекурсии.

Console.Clear();
int NullOff(string txt)
{
    Console.Write(txt);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
void SteepNum(int m, int n)
{
    if (m > n) return;
    if (m%2 == 0)
    Console.Write($"{m}, ");
    else if (m == n) return;
    else
    Console.Write($"{m+1}, ");
    SteepNum(m + 2, n);
}

int M = NullOff("Введите первое число:  ");
int N = NullOff("Введите второе число:  ");
SteepNum(M, N);