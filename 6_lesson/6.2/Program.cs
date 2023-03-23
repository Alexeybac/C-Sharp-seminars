// void BinarCode(int num, int i)
// {
//     if (num == 0) return;
//     Console.Write($"{num%i}");
//     BinarCode(num/i, i);
// }

// Console.Write("Введите число и разрядность: ");
// BinarCode(int.Parse(Console.ReadLine()),
//           int.Parse(Console.ReadLine()));

string BinCode (int N)
{
    string txt = string.Empty;
    while(N != 0)
    {
        txt = N%2 + txt;
        N = N/2;
    }
    return txt;
}
int NullOff (string text)
{
    Console.Write(text);
    var s = Console.ReadLine();
    int n = s == null ? 0 : int.Parse(s);
    return n;
}

int N = NullOff("Введите число N: ");
string rez = BinCode(N);
Console.Write(rez);