// Пользователь вводит с клавиатуры М чисел,
// посчитайте, сколько введено чисел больше нуля.

Console.WriteLine("Введите кучу чисел: ");
int Counts()
{

    string txt;
    int count = 0;
    while (true)
    {
        txt = Console.ReadLine();
        if (txt == string.Empty) return count;
        else if (int.Parse(txt) > 0) count++;
    }
}

Console.Write($"Количество полижительных чисел из введенных => {Counts()}");

// var s = int.Parse(Console.ReadLine());
// int count = 1;
// while (s != null)
// {
//     s = int.Parse(Console.ReadLine());
//     if (s > 0 ) count++;
// }
// Console.WriteLine(count);