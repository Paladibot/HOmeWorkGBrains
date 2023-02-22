int randNum = new Random().Next(100, 1000);
int result = (randNum / 100) * 10 + randNum % 10;
Console.WriteLine($"{randNum} --> {result}");

//918 = 9 * 100 + 1 * 10 +8     918 / 100 = 9
//98 = 9 * 10 + 8