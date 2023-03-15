// Принимает на вход цифру,
// обозначающую день недели,
// и проверяет, является ли этот день выходным.


void Week(int n)
{
    if (n == 6 || n == 7)
    Console.WriteLine("Урраааа, ВЫХОДНЫЫЫЕ!!!");
    else if ( n < 1 || 7 < n)
    Console.WriteLine("Таких дней недели НЕ бывает, abort");
    else
    Console.WriteLine("Будни, блин(((");
}

Console.Write("Введите чОньть   ");
int N = int.Parse(Console.ReadLine());
Week(N);

