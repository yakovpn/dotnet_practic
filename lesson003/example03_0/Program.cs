int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
void Quarters(int x, int y)
{
    if (x == 0 || y == 0)
        Console.WriteLine("Точка лежит на оси и не попадает в плоскость");
    else if (x > 0 && y > 0)
        Console.WriteLine("I");
    else if (x < 0 && y > 0)
        Console.WriteLine("II");
    else if (x < 0 && y < 0)
        Console.WriteLine("III");
    else if (x > 0 && y < 0)
        Console.WriteLine("IV");
}

int x = ReadNumber("Введите X:");
int y = ReadNumber("Введите Y:");
if (x == y)
{
    Console.WriteLine("Ошибка ввода");
    return;
}
Quarters(x, y);