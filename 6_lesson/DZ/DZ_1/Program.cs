// Пользователь вводит с клавиатуры М чисел,
// посчитайте, сколько введено чисел больше нуля.


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

Console.WriteLine("Введите кучу чисел: ");
Console.Write($"Количество полижительных чисел из введенных => {Counts()}");
