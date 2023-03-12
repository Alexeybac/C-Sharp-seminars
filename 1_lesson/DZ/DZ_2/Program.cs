// Принимает на вход три числа 
// и выдает максимальное из этих чисел.

Console.WriteLine("Введите три числа, через ввод:   ");
int n1= int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());


int [] massiv = {n1, n2, n3};

int count = massiv.Length;
int i = 0;
int max = massiv[0];
while(i < count)
{
    if(massiv[i] > max) max = massiv[i];
    i += 1;
}
Console.Write("Максимальное число из трех введенный будет:   ");
Console.WriteLine(max);
