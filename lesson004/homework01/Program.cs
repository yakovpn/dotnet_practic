//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
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

int a = ReadInt("Введите числоа А:");
int b = ReadInt("Введите числоа B:", true, 1);

int res = a;
//while (b > 1)
//{
//    res = res * a;
//    b--;
//}
for (int i = 1; i < b; i++)
{
  res = res * a;
}
Console.WriteLine($"Число А:{a} в степени B:{b} равно {res}");