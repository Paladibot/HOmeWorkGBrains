Console.Write("Введите число номер один: ");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите число номер два: ");
double b = double.Parse(Console.ReadLine());
Console.Write("Введите число номер три: ");
double c = double.Parse(Console.ReadLine());


double max = a;

if (a > b) max = a;
if (a > c) max = a;

if (b > c) max = b;
if (b > a) max = b;

if (c > b) max = c;
if (c > a) max = c;

Console.WriteLine("Максимальное из трех значений: " + max);

