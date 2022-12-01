int ReadInt(string message, bool filterEnable = false, int minRange = 0, int maxRange = 999999999)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    if (filterEnable)
    {
        if (a < minRange || a > maxRange)
        {
            Console.WriteLine("Ошибка ввода");
            Environment.Exit(-1);
        }
    }
    return a;
}

int n = ReadInt("Введите число:", true, -999999999);
n = Math.Abs(n);
int digitCount = 0;
if (n == 0)
{
    Console.WriteLine($"В числе {n} 1 знак");
}
else
{
    while (n > 0)
    {
        n /= 10;
        digitCount++;
    }
    Console.WriteLine($"В числе {n} {digitCount} знаков");
}
