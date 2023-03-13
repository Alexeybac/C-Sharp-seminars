// Выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.


Console.Write("Задайте число: ");
int n = int.Parse(Console.ReadLine());


if (n <= 99) 
{
    Console.WriteLine($"Облом, цифра {n} не трехсначная!");
}
else 
{
while ( n >= 1000)
{
    n/=10;
}
Console.WriteLine($"Третья цифра будет: - {n%10}");
}



     

