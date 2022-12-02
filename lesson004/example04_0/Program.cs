int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

int a = ReadNumber("введите число:");
int result = 0;
for (int i = 1; i <= a; i++)
{
    result += i;
}
Console.WriteLine($"Сумма чисел от 1 до {a} = {result}");