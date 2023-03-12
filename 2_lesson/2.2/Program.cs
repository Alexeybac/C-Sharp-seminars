
Console.WriteLine("Введите два числа построчно:  ");
int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());

if (n1%n2 == 0)
Console.WriteLine("кратно");
else
Console.WriteLine($"Не кратно, остаток {n1%n2}");