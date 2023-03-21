// 

int[] Fillaray(int size, int x, int y)       // Формируем массив размером size:
{
    int[] aray = new int[size];
    int leng = aray.Length;

    for (int i = 0; i < leng; i++)
    {
        aray[i] = new Random().Next(x, y);
    }
    return aray;
}
void Printaray(int[] aray)     // Печатает сформированый массив (чтобы просто посмотреть)
{
    int leng = aray.Length;
    for (int i = 0; i < leng; i++)
    {
        Console.Write($"{aray[i]}, ");
    }
    Console.WriteLine();
}
void sum(int [] aray)          // вычисляем и выводим на печать суммы плюсов и минусов
{
    int sumup = 0;
    int sumdown = 0;
    int leng = aray.Length;
    for (int i = 0; i < leng; i++)
    {
        if (aray[i] >= 0) sumup += aray[i];
        else
        sumdown += aray[i];
    }
    Console.WriteLine($"Сумма положительных чисел массива =>     {sumup}");
    Console.WriteLine($"Сумма отрицательных чисел массива =>     {sumdown}");
    Console.WriteLine();
}

Console.Write("Введите, построчно, разряд массива и размерность наполнения : ");
// int N = int.Parse(Console.ReadLine());
// int x = int.Parse(Console.ReadLine());
// int y = int.Parse(Console.ReadLine());
int [] mass = Fillaray(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Console.Write("Получен массив =>    ");
Printaray(mass);
Console.WriteLine();
Console.WriteLine("Из которого:   ");
Console.WriteLine();
sum(mass);