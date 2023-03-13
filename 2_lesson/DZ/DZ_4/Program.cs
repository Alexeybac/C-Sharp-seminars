// Принимает на вход цифру,
// обозначающую день недели,
// и проверяет, является ли этот день выходным.

void weekday (int n)
{
    if ( 5 < n && n < 8)
    Console.WriteLine("Этот день - выходной!!!");
    else if ( n < 1 || 7 < n )
    Console.WriteLine("Такого номера дня недели не бывает!");
    else
    Console.WriteLine("Этот номер дня  -  будни()");
}


Console.WriteLine("Введем любой номер дня недели от 1 до 7:   ");
weekday(int.Parse(Console.ReadLine()));
