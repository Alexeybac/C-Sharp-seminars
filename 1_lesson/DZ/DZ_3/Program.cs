// На вход принимает число
// и выдает, является ли число четным
// (делится ли оно на два без остатка).

Console.Write("Введите число N:  ");
int N = int.Parse(Console.ReadLine());

int abs = N%2;

if(abs != 0) 
Console.Write("Число N нечетное");
else
Console.Write("Число N четное");