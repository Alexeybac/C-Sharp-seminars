// Принимает на вход трехзначное число,
// на выходе показывает вторую цифру этого числа.

Console.Write("Ведите трехзначное число N:  ");

void snd_number(int N)
{
if ( 99 < N && N < 1000)
Console.WriteLine($"Из введенного числа {N}, вторая цифра будет {N/10%10}");
else
Console.WriteLine($"Ошибка!!");
}

snd_number(int.Parse(Console.ReadLine()));