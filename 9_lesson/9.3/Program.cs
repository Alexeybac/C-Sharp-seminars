// Рекурсия выводит сумму цифр числа N.

Console.Clear();
int NullOff(string txt)
{
    Console.Write(txt);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
int SumNum (int N)
{
    if (N%10 == 0) return 0;
    return N%10 + SumNum(N/10);
}

int n = NullOff("Введите число M:  ");
Console.Write(SumNum(n));