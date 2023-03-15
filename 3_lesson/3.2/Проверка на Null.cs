
int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

double Funck (int x1, int y1, int x2, int y2)
{
    double rez = Math.Sqrt(Math.Pow((x2 - x1),2) +  Math.Pow((y2 - y1),2));
    return rez;
}

int X1 = ReadNumber("Введите Xa: ");
int Y1 = ReadNumber("Введите Ya: ");
int X2 = ReadNumber("Введите Xв: ");
int Y2 = ReadNumber("Введите Yв: ");

// Console.WriteLine("Введите координаты первой точки по строчно: ");
// double X1 = double.Parse(Console.ReadLine());
// double Y1 = double.Parse(Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки по строчно: ");
// double X2 = double.Parse(Console.ReadLine());
// double Y2 = double.Parse(Console.ReadLine());

Console.WriteLine($"Результат:  {Math.Round(Funck(X1,Y1,X2,Y2),2)}");