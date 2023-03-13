void Vizib(int num)
{
    if(num % 7 == 0 && num % 23 == 0)
    Console.WriteLine("Число кратное");
    else
    Console.WriteLine("Число НЕ кратное");
}

Console.WriteLine("Введите число: ");
// int n = int.Parse(Console.ReadLine());
Vizib(int.Parse(Console.ReadLine()));