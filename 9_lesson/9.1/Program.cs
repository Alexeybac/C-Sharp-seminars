
// Рекурсия выводит от 1 до N.

Console.Clear();
int NullOff (string txt)
{
    Console.Write(txt);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
void Nums (int N)
{
    if (N < 1) return;
    Nums(N-1);
    Console.Write($"{N}, ");
    
}

int n = NullOff("Введите число N:  ");
Nums(n);
