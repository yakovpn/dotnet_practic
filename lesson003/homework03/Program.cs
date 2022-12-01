//Задача 3: Напишите программу, которая принимает на
//вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27.
//5 -> 1, 8, 27, 64, 125
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

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
    Console.WriteLine(Math.Pow(N, 3));
    N--;
}
