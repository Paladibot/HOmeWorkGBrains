Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите Второе число: ");
int b = int.Parse(Console.ReadLine());

if (a % b == 0) Console.Write($"{b} Kratno {a}");
else Console.WriteLine(a % b);

