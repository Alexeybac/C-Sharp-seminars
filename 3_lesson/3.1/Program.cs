

void Point(string x)
{
    if (x == "I" || x == "1") Console.Write($"X > 0 и Y > 0");
    if (x == "II" || x == "2") Console.Write($"X < 0 и Y > 0");
    if (x == "III" || x == "3") Console.Write($"X < 0 и Y < 0");
    if (x == "IV" || x == "4") Console.Write($"X > 0 и Y < 0");
    return;
}

Console.WriteLine("Введите номер плоскости:");
string X = Console.ReadLine();


Point(X);
