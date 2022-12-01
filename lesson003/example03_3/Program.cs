int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

int N = ReadNumber("Введите N (число должно быть больше либо равно 1):");
if (N <= 0)
{
    Console.WriteLine("Ошибка ввода");
    return;
}
while (N >= 1)
{
    Console.WriteLine(Math.Pow(N, 2));
    N--;
}
