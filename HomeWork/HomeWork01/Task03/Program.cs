
Console.Write("Введите число на проверку: ");
double a = double.Parse(Console.ReadLine());

int count = 1;

while(count <= a)
{
    if (count % 2 != 1)
    {
      Console.Write(count + ", ");
      
    }
    
  count++;
}

if (a <= 1)
    {
        Console.WriteLine("Нету четных чисел");
    }

