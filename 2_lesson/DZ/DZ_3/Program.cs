// Выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
void num(int x)
{
  int x1 = x;
    if(-100 < x && x < 100) 
        Console.Write($"Третей цифры у введенного числа - {x} НЕТ!");
    else
    {
        int x2 = Math.Abs(x);
        while (x2 > 999) x2 = x2/10;
        Console.Write($"У числа - {x1} третья цифра будет - {x2%10}");
    }
}
Console.Write("Введите любое число -  ");
int n = int.Parse(Console.ReadLine());
num(n);
