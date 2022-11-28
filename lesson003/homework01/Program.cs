//Задача 1: Напишите программу, которая принимает на
//вход пятизначное число и проверяет, является ли оно
//палиндромом.
//14212 -> нет
//23432 -> да
//12821 -> да

// Делаем через арифметические операции, можно сделать и через строки, 
//1) 5тизначное число! ограничить диапазон 
//2)Сравнивать пары, 
//3) в цикле while

int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

int a = ReadNumber("Введите пятизначное число:");
if (a < 10000 || a > 99999)
{
    Console.WriteLine("Ошибка ввода");
    return;
}
int[] num = new int[6];
for (int i = 0; i < 5; i++)
{
    num[4-i]=a/(Convert.ToInt32(Math.Pow(10,i)))%10;
}
if (num[4]==num[0] && num[3]==num[1]) {
    Console.WriteLine("Введенное число является полиндромом");
} else {
    Console.WriteLine("Введенное число НЕ является полиндромом");
}