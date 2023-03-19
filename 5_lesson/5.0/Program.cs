// 

int[] Fillaray(int size)       // Формируем массив размером size:
{
    int[] aray = new int[size];
    int leng = aray.Length;

    for (int i = 0; i < leng; i++)
    {
        aray[i] = new Random().Next(-9, 9);
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
        sumdown += aray[i];
    }
    Console.WriteLine($"Сумма положительных чисел массива =>     {sumup}");
    Console.WriteLine($"Сумма отрицательных чисел массива =>     {sumdown}");
    Console.WriteLine();
}

Console.Write("Введите разряд массива: ");
// int N = int.Parse(Console.ReadLine());
int [] mass = Fillaray(int.Parse(Console.ReadLine()));
Console.Write("Массив =>    ");
Printaray(mass);
Console.WriteLine();
sum(mass);