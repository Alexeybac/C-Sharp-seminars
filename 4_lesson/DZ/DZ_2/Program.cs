// На входе число,
// на выходе сумма цифр в числе.

int Nulof (string text)        // Исключение пустой строки
{
    Console.Write(text);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
int Sum (int N)                 // Решение через рекурсию! 
{
    if (N == 0) return N = 0;
    else 
    return N = N%10 + Sum(N/10);

}

int x = Nulof("Введите число:  ");
Console.Write(Sum(x));