/* Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());

if(a > 999 || a < 100)
{
   Console.WriteLine("Неверное значение");   
} 

else
{
   int b = a % 100;
   int c = b / 10;
   Console.WriteLine(c); 
}  */
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


string NumberTwoDelete(int num)
{
  if ((num < 1000 && num > 100) || (num < -1000 && num > -100))
     return $"{num} --> {num % 100 / 10}";
   return "Неверное число";
}

int val = int.Parse(Console.ReadLine()!);
string result = NumberTwoDelete(val);
Console.WriteLine(result);