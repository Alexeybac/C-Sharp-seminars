int NullOff (string text)
{
    Console.Write(text);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
int [] Fibonaccy (int N)
{
    int [] fib = new int[N];
    fib[0] = 0;
    fib[1] = 1;
    for (int i = 2; i < N; i++)
    {
        fib [i] = fib[i-1] + fib[i-2];
    }
    return fib;
}
void PrintFib (int [] aray)
{
    Console.Write("Расклад по Фибоначи: => ");
    for (int i = 0; i < aray.Length; i++)
    {
        Console.Write($"{aray[i]} ");
    }
}

int [] arr = Fibonaccy(NullOff("Введите число Фибоначи: "));
PrintFib(arr);