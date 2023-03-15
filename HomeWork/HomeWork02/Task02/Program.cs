//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

/* Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());


if (a < 100) Console.WriteLine("Третьей цифры нет");
else
{
    int b = a % 10;
    Console.WriteLine(b);
    if(a == 0) Console.WriteLine("0");

}
*/

int NumberThreeWrite(string str)
{ 
  return Convert.ToInt32(Convert.ToString(str.ToCharArray()[2]));  
}

string val = Console.ReadLine()!;

if(val.Length < 3)
  Console.WriteLine("3 цифры нету");
else
  Console.WriteLine(10 * NumberThreeWrite(val));

