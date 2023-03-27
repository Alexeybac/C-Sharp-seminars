// Рекурсия выводит число n в степень i.

Console.Clear();
int NullOff(string txt)
{
    Console.Write(txt);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
int NumStep (int N, int i)
{
    if (i == 0) return 1;
    return N * NumStep(N, i-1);
}

int n = NullOff("Введите число:  ");
int i = NullOff("Введите степень:  ");
Console.Write($"Результат: {NumStep(n, i)}");
