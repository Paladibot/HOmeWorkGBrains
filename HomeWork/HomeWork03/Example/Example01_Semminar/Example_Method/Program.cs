// 1 Вид (Не возвращают, не принимают)

  void Method1()
{
  Console.WriteLine("Text...");
}
Method1();

// 2 Вид (Принимают, не возвращают)

void Method2(string msg) 
{
    Console.WriteLine(msg);
}
Method2(msg: "Hello");

void Method21(string msg, int count) //Принимает текст, выводит его заданным количеством в консоли
{
   int i = 0;
   while(i < count)
   {
      Console.WriteLine(msg);
      i++;
   }
}
Method21(msg:"Text", count: 4);


// Вид 3 (Не принимает, возвращает)

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();

Console.WriteLine(year);

// Вид 4 (Принимает, возвращает) 

string Method4(int count, string text)
{
    
    string result = String.Empty;

   for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
    
}
  string res = Method4(count: 10, text: "Text");
  Console.WriteLine(res); 

  for(int i = 2; i <= 10; i++)
  {
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
  }  
  