int Max_num(int n1, int n2)
{
int rand = new Random().Next(n1,n2);
Console.Write($"Максимальной цифрой рандомного числа - {rand} является - ");
    if (rand/10 > rand%10)
    return rand/10;
    else
    return rand%10;
}

int Min_num(int n1, int n2)
{
int rand = new Random().Next(n1,n2);
Console.Write($"Минимальной цифрой рандомного числа - {rand} является - ");
    if (rand/10 < rand%10)
    return rand/10;
    else
    return rand%10;
}

Console.Write("Введите нижний предел (минимум 10) MIN:  ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите верхний предел (максимум 100) MAX:  ");
int max = int.Parse(Console.ReadLine());

Console.WriteLine(Max_num(min,max));
Console.WriteLine(Min_num(min,max));

