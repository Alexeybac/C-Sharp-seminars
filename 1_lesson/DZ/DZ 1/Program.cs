// На вход принимает два числа и выдает, 
// какое число больше, а какое меньше.

Console.Write("Введите первое число N1:  ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число N2:  ");
int n2 = int.Parse(Console.ReadLine());

if (n1 < n2) 
    Console.WriteLine($"Второе число {n2} больше первого {n1}");
else
    Console.Write($"Первое число {n1} больше второго {n2}");
