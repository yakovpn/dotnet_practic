Console.Write("Ведите первое число:");
var s = Console.ReadLine();
int a = s == null ? 0 : int.Parse(s);
Console.Write("Ведите второе число:");
s = Console.ReadLine();
int b = s == null ? 0 : int.Parse(s);
if ((b * b) == a)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}


