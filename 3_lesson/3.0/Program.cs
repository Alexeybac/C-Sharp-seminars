

void point(int x, int y)
{
    if (x > 0 && y > 0) Console.Write($"Точка находится в плоскости: - {1}");
    if (x < 0 && y > 0) Console.Write($"Точка находится в плоскости: - {2}");
    if (x < 0 && y < 0) Console.Write($"Точка находится в плоскости: - {3}");
    if (x > 0 && y < 0) Console.Write($"Точка находится в плоскости: - {4}");
    if (x == 0 || y == 0) return;//Console.Write($"Точка находится в центре");
}

Console.WriteLine("Введите координаты Х и Y построчно:");
int X = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());

point(X, Y);
