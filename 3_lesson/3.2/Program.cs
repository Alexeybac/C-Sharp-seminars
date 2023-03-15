

double Funck (double x1, double y1, double x2, double y2)
{
    double rez = Math.Sqrt(Math.Pow((x2 - x1),2) +  Math.Pow((y2 - y1),2));
    return rez;
}

Console.WriteLine("Введите координаты первой точки по строчно: ");
double X1 = double.Parse(Console.ReadLine());
double Y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки по строчно: ");
double X2 = double.Parse(Console.ReadLine());
double Y2 = double.Parse(Console.ReadLine());

Console.WriteLine($"Результат :  {Math.Round(Funck(X1,Y1,X2,Y2),2)}");