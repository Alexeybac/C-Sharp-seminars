// Принимает на вход трехзначное число,
// на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число N - ");
int N = int.Parse(Console.ReadLine());

if (N>99 && N<1000) 
Console.WriteLine($"Вторая цифра числа N является: - {N/10%10}");
else
Console.WriteLine("!!!Ошибочка!!!");
Console.Write("Введите ТРЕХ-значное число N - ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Вторая цифра числа N является: - {n/10%10}");