
// Вариант 1.

void Fillaray(int [] n)
{
    int length = n.Length;
    for (int i = 0; i < length; i++)
    {
        n[i] = new Random().Next(0,2);
    }
}
void Printaray(int[] m)
{
    int length = m.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(m[i]);
        Console.Write(", ");
    }
}

Console.Write("Введите размер массива: ");
int N = int.Parse(Console.ReadLine());
int[] mass = new int[N];
Fillaray(mass);
Printaray(mass);


// Вариант 2:


void Massiv(int n)
{
int[] mass = new int[n];
    for (int i = 0; i < n; i++)
    {
        mass[i] = new Random().Next(0,2);
        Console.Write($"{mass[i]}, ");
    }
}

Console.WriteLine();
Console.Write("Введите размер массива: ");
Massiv(int.Parse(Console.ReadLine()));