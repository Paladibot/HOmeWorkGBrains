Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a * a == b || b * b == a) Console.WriteLine("Одно из чисел квадрат другого");
else Console.WriteLine("Нет");