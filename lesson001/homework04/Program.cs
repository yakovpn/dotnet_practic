int b = 1;
Console.Write($"Ведите число N (N должно бфть больше {b}):");
var s = Console.ReadLine();
int N = s == null ? 0 : int.Parse(s);
if (N <= b)
{
    Console.WriteLine("Ввод не правильный");
}
else
{
    b = b % 2 == 0 ? b : b + 1; //Начнем цикл обязательно с четного ;)
    while (b <= N)
    {
        if (b % 2 == 0) Console.Write($" {b}");
        b += 2;
    }
    Console.WriteLine(); //Перевод строки
}