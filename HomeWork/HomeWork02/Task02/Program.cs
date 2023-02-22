//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());


if (a < 100) Console.WriteLine("Третьей цифры нет");
else
{
    int b = a % 10;
    Console.WriteLine(b);
    if(a == 0) Console.WriteLine("0");

}



