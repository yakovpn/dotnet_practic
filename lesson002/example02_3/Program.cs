Console.Write("Ведите число:");
var s = Console.ReadLine();
int a = s == null ? 0 : int.Parse(s);
if (a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine($"Число {a} кратно числам 7 и 23");
}
else
{
    Console.WriteLine($"Число {a} НЕ кратно числам 7 и 23");
}