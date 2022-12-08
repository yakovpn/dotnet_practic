using DotNetPractic;
public partial class lesson006
{

    ///<summary>
    /// Домашнее задание №1
    ///</summary>
    ///<remark>
    ///Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
    ///0, 7, 8, -2, -2 -> 2
    ///1, -7, 567, 89, 223-> 3
    ///</remark>
    public void homeWorkBody1()
    {

        int count = 0;
        int a;
        while (true)
        {
            try
            {
                a = DNPTools.ReadInt("Введите число:", true, Int32.MinValue);
                if (a > 0) count++;
            }
            catch (Exception e)
            {
                if (e.Message == "Empty string")
                {
                    Console.WriteLine($"Количество введенных чисел больше нуля: {count}");
                    break;
                }
                else
                {
                    Console.WriteLine("Ошибка ввода");
                    break;

                }
            }
        }
    }
    ///<summary>
    ///Домашнее задание №2
    ///</summary>
    ///<remark>
    ///Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
    ///заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    ///b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    ///<remark>
    public void homeWorkBody2()
    {
        double b1 = DNPTools.ReadInt("Введите b1:");
        double k1 = DNPTools.ReadInt("Введите k1:");
        double b2 = DNPTools.ReadInt("Введите b2:");
        double k2 = DNPTools.ReadInt("Введите k2:");
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения двух прямых находится в координатах [{Math.Round(x, 2)},{Math.Round(y, 2)}]");
    }
}