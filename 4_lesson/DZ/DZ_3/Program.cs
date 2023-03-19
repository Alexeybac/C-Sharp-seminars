// Создает массив из 8-ми случайных чисел,
// и выдает его на экран.

void Fillaray (int [] x, int y1, int y2)
{
    int leng = x.Length;
    for (int i = 0; i < leng; i++)
    {
        x[i] = new Random().Next(y1,y2);
    }
}
void Printaray (int [] y)
{
    int leng = y.Length;
    for (int i = 0; i < leng; i++)
    {
        Console.Write($"{y[i]}, ");
    }
}

Console.Write("Введите размер массива: ");
int [] aray = new int[int.Parse(Console.ReadLine())];
Console.WriteLine("Введите, построчно, интервал наполняемых цифр, Пример от 10 до 100: ");
int Y1 = int.Parse(Console.ReadLine());
int Y2 = int.Parse(Console.ReadLine());
Fillaray(aray, Y1, Y2);
Printaray(aray);