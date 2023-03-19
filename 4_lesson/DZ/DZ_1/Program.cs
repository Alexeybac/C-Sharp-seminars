// Принимает два числа,
// возвращает первое число,
// в натуральную степень второго числа.


double Step1 (double a, int b)           // Вариант через цикл!
{
    double st = a;
    for(int i = 1; i < b; i++)
    {
        a = a*st;
    }
    return a;
}

double Step2 (double a, int b)           // Вариант через степень!
{
    return Math.Pow(a,b);
}
// Ввод данных
Console.WriteLine("Введите два числа, построчно: ");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
// Обработка и вывод результата
Console.Write($" Вариант через цикл =>    {Step1(x,y)}");
Console.WriteLine();
Console.WriteLine();
Console.Write($" Вариант через степень => {Step2(x,y)}");
Console.WriteLine();
Console.WriteLine();