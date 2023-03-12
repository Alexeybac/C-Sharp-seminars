// На вход принимает число N
// на выходе показывает все четные числа от 1 до N.

Console.Write("Введите, наконец, какое нибудь число N:  ");
int N = int.Parse(Console.ReadLine());



int  i = 2;
while(i <= N)
{
    Console.Write($"{i}, ");
    i +=2;
}