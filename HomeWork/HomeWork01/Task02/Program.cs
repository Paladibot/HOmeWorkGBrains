Console.Write("Введите число на проверку: ");
double a = double.Parse(Console.ReadLine());

if (a % 2 == 1)
{
    Console.WriteLine("Число " + a + ", является нечетным!");
}
else
{
    Console.WriteLine("Число " + a + ", является четным!");
}
