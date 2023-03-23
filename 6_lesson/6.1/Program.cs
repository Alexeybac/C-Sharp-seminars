
int NullOff(string txt)
{
    Console.WriteLine(txt);
    var s = Console.ReadLine();
    int x = s == null ? 0 : int.Parse(s);
    return x;
}

string Triangl()
{
    Console.WriteLine("Введите длины сторон построчно.");
    int a = NullOff("Введите сторону А: ");
    int b = NullOff("Введите сторону Б: ");
    int c = NullOff("Введите сторону С: ");
    if (a + b > c && a + c > b && c + b > a) return "Да!";
    return "Нет!";
}

// Console.WriteLine("Введите длины сторон построчно.");
// int x = NullOff("Введите сторону А: ");
// int y = NullOff("Введите сторону Б: ");
// int z = NullOff("Введите сторону С: ");

Console.WriteLine(Triangl());
