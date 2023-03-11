Console.Write("Введите первое число: ");
int quatro = int.Parse(Console.ReadLine());

Console.Write("Введите второе число А: ");
int a = int.Parse(Console.ReadLine());

if(a*a == quatro) Console.WriteLine($"Число А - является корнем числа {quatro}!");
else Console.WriteLine($"Число А - НЕ является корнем числа {quatro}!");
Console.WriteLine("Конец :) ");
