// 2. Напишите программу, которая принимает на вход
//    число N и выдаёт произведение чисел от 1 до N.


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

int n = ReadInt("Введите число:", true, 1);
int result = 1;
for (int i = 1; i <= n; i++)
{
    result = result * i;
}
Console.WriteLine(result);
