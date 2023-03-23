
int[] CreateMassiv (int size, int from, int to)
{
    Console.Write($"Массив:=>                ");
    int [] mass = new int[size];
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(from,to);
        Console.Write($"{mass[i]}  ");
    }
    Console.WriteLine();
    return mass;
}

int [] ReversMassiv (int [] arr) //Разворот массива через переменную
{
    Console.Write($"Перевернутый массив:=>   ");

    for (int i = 0; i < arr.Length/2; i++)
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }

    return arr;
}

void RevMass (int [] arr)        //Разворот массива КОРТЕЖЕМ
{
    Console.Write($"Вернули обратно:=>       ");
    for (int i = 0; i < arr.Length/2; i++)
        (arr[i], arr[arr.Length-1-i]) = (arr[arr.Length-1-i], arr[i]);
    for (int i = 0; i < arr.Length; i++)
         Console.Write($"{arr[i]}  ");
}

int [] array = CreateMassiv(int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()),
                            int.Parse(Console.ReadLine()));

ReversMassiv(array);
Console.WriteLine();
RevMass(array);