// Принимает пятизначное число,
// проверяет, является ли оно палиндромом.

// Метод числа:

int Nulloff (string text)
{
    Console.Write(text);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
void Palindrom (int x)
{
    if (x/10000 == x%10 && x/1000%10 == x/10%10)
    Console.WriteLine($"Число {x} является палиндромом 'зеркальным'");
    else
    Console.WriteLine($"Число {x} НЕ палиндром");
}

int N = Nulloff("Введите пятизначное число:  ");
Palindrom(N);

// Метод строки:

void Polindrom (double n)
{
    int i = 0;
    string text = n.ToString();
    int leng = text.Length-1;
    string f = "!!!ПОЛИНДРОМ!!!";
    while(i <= leng/2)
    {
        if (text[i] != text[leng-i]) 
        {
            f = "!!!НЕ полиндром!!!";
            break;
        }
        i++;
    }
    Console.Write($"Число {n} = > {f}");
}

double num = Nulloff("Введите ЛЮБОЕ число II: ");
Polindrom(num);