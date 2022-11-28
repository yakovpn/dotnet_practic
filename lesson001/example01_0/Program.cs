Console.Write("Введите число:");
var s = Console.ReadLine();
int a = s == null ? 0 : int.Parse(s);
Console.WriteLine("Квадрат этого числа = " + (a * a).ToString());
