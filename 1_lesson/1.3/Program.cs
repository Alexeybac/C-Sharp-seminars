
// Console.Write("Введите число:  ");
// int N = int.Parse(Console.ReadLine());

// for (int i = 0; i < N; i++)
// {
//         Console.Write(N*-1 + i);
//         Console.Write(", ");
// }
// for (int i = 0; i < N+1; i++)
// {
//         Console.Write(i);
//         Console.Write(", ");
// }

Console.Write("Введите число:  ");
int N = int.Parse(Console.ReadLine());

for (int i = -N; i <= N; i++)
{
        Console.Write($"{i}, ");
        // Console.Write(", ");
}