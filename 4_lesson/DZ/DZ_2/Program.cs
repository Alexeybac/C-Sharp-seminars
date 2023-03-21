// На входе число,
// на выходе сумма цифр в числе.

int Nulof (string text)        // Исключение пустой строки
{
    Console.Write(text);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
int Sum (int N)                // Решение через рекурсию! 
{
    if (N == 0) return N = 0;
    else 
    return N = N%10 + Sum(N/10);

}
double text ( int N)           // Решение через CHAR строку
{
    string txt = N.ToString();
    int leng = txt.Length;
    double summ = 0;
    for(int i = 0; i < leng; i++)
    {
        double m = char.GetNumericValue(txt[i]); // Перевод символа цифры массива txt[i] в число m
        summ = summ + m;
    }
    return summ;
}

int x = Nulof("Введите число:  ");
Console.WriteLine($"Решение через рекурсию :      => {Sum(x)}");
Console.Write($"Решение через char и строку : => {text(x)}");