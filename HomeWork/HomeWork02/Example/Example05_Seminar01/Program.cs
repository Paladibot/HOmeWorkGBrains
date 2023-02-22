int randNum = new Random().Next(10, 100);
int a = randNum % 10;
int b = randNum / 10;

int max = a;
if(a < b) max = b;

Console.WriteLine($"Максимальная цифра числа {randNum} -> {max}");