// На вход принимает число N
// на выходе показывает все четные числа от 1 до N.

Console.Write("Введите, наконец, какое нибудь число N:  ");
int N = int.Parse(Console.ReadLine());



int  i = 0;
while(i < N-1)
{
    Console.Write($"{i + 2}, ");
    i +=2;
}