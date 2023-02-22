Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

if(a % 7 == 0 && a % 23 == 0) Console.WriteLine(a + " Кратно ");
else Console.WriteLine("Число не кратно");