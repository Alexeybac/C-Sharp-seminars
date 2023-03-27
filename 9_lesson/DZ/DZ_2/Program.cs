// Задайте значения M и N, 
// выводит сумму натуральных чисел в промежутке от M до N,
// с помощью рекурсии.

Console.Clear();
int NullOff(string txt)
{
    Console.Write(txt);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
int SteepSum(int m, int n)
{
    if (m > n) return 0;
    return m + SteepSum(m + 1, n);
}


int M = NullOff("Введите первое число:  ");
int N = NullOff("Введите второе число:  ");
Console.WriteLine(SteepSum(M, N));

Console.ReadKey();