// Принимает координаты двух точек,
// и находит расстояние между ними в 3D пространстве.

int Nulloff (string text)
{
    Console.Write(text);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

double Rezult ( int Ax, int Ay, int Az, int Bx, int By, int Bz)
{
    double rez = Math.Sqrt(Math.Pow((Bx - Ax),2) + Math.Pow((By - Ay),2) + Math.Pow((Bz - Az),2));
    return rez;
}

int a1 = Nulloff("Введите Ах: ");
int a2 = Nulloff("Введите Аy: ");
int a3 = Nulloff("Введите Аz: ");
int b1 = Nulloff("Введите Вх: ");
int b2 = Nulloff("Введите Вy: ");
int b3 = Nulloff("Введите Вz: ");

double N = Math.Round(Rezult(a1, a2, a3, b1, b2, b3),2);

Console.Write($"Сумма двух векторов А и B => {N}");


