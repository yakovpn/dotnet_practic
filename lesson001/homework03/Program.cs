Console.Write("Ведите число:");
var s = Console.ReadLine();
int a = s == null ? 0 : int.Parse(s);
if (a % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число не четное");
}