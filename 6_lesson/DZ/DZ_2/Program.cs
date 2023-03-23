// y = k1*x + b1
// y = k2*x + b2
// Найти координаты точки пересечения.
int NullOff (string text)
{
    Console.Write(text);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
void Peresech(double k1, double b1, double k2, double b2)
{
    // Console.WriteLine($"k1 = {k1} ");
    // Console.WriteLine($"b1 = {b1} ");
    // Console.WriteLine($"k2 = {k2} ");
    // Console.WriteLine($"b2 = {b2} ");
    double x = Math.Round((b2 - b1) / (k1 - k2),1);
    double y = k1 * x + b1;
    Console.WriteLine($"(x,y) = ({x},{y})");
}
Console.WriteLine("Введите коэффициенты: ");
int b1 = NullOff("Введите b1: ");
int k1 = NullOff("Введите k1: ");
int k2 = NullOff("Введите k2: ");
int b2 = NullOff("Введите b2: ");

Console.WriteLine("Координаты точки пересечения двух функций:");
Peresech(k1, b1, k2, b2);
