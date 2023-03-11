
Console.Write("Введите номер дня недели:  ");
int a = int.Parse(Console.ReadLine());

if ( a == 1) Console.WriteLine("Понедельник");
if ( a == 2) Console.WriteLine("Вторник");
if ( a == 3) Console.WriteLine("Среда");
if ( a == 4) Console.WriteLine("Четверг");
if ( a == 5) Console.WriteLine("Пятница");
if ( a == 6) Console.WriteLine("Суббота");
if ( a == 7) Console.WriteLine("Воскресение");
if (1 > a) Console.WriteLine("Дни недели закончились");
if (a > 7) Console.WriteLine("Дни недели закончились");

string [] days = {"Понедельник", "Вторник", "Среда",
                   "Четверг", "Пятница", "Суббота", "Воскресение"};

Console.Write("Или введите число от 1 до 7 :  ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine($" День недели будет - {days[m-1]}");