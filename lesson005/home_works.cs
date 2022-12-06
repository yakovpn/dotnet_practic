using DotNetPractic;
public partial class lesson005
{

    ///<summary>
    /// Домашнее задание №1
    ///</summary>
    ///<remark>
    ///Задача 1: Задайте массив заполненный случайными
    ///положительными трёхзначными числами. Напишите
    ///программу, которая покажет количество чётных чисел в
    ///массиве.
    ///[345, 897, 568, 234] -> 2
    ///</remark>
    public void homeWorkBody1()
    {
        int arrLength = DNPTools.ReadInt("Введите длину массива:", true);
        int[] arr = DNPTools.FillIntArr(new int[arrLength], 100, 999);
        Console.WriteLine($"Сформирован массив:[{DNPTools.ArrToStr(arr)}]");
        int count = 0;
        for (int i = 0; i < arrLength; i++)
        {
            if (arr[i] % 2 == 0) count++;

        }
        Console.WriteLine($"В массиве {count} четных занчений");
    }
    ///<summary>
    ///Домашнее задание №2
    ///</summary>
    ///<remark>
    ///Задача 2: Задайте одномерный массив, заполненный
    ///случайными числами. Найдите сумму элементов, стоящих
    ///на нечётных позициях.
    ///[3, 7, 23, 12] -> 26
    ///[-4, -6, 4, 67] -> 0
    ///<remark>
    public void homeWorkBody2()
    {
        int arrLength = DNPTools.ReadInt("Введите длину массива:", true, 2);
        int[] arr = DNPTools.FillIntArr(new int[arrLength], 0, 9);
        Console.WriteLine($"Сформирован массив:[{DNPTools.ArrToStr(arr)}]");
        int summ = 0;
        for (int i = 0; i < arrLength; i += 2) summ += arr[i];
        Console.WriteLine($"Суммы значений элементов массива на нечётных позициях равна {summ}");
    }
    /// <summary>
    /// Домашнее задание №3
    ///</summary>
    ///<remark>
    ///Задача 3: Задайте массив вещественных чисел. Найдите
    ///разницу между максимальным и минимальным
    ///элементов массива.
    ///[3, 7, 22, 2, 78] -> 76
    ///</remark>
    public void homeWorkBody3()
    {
        int arrLength = DNPTools.ReadInt("Введите длину массива:", true, 2);
        double[] arr = DNPTools.FillDoubleArray(new double[arrLength], 10, 20);
        Console.WriteLine($"Сформирован массив:[{DNPTools.ArrToStr(arr)}]");
        int indexMin = 0;
        int indexMax = 0;
        for (int i = 0; i < arrLength; i++)
        {
            if (arr[indexMin] > arr[i]) indexMin = i;
            if (arr[indexMax] < arr[i]) indexMax = i;
        }

        Console.WriteLine($"Разница между максимальным и минимальным значнием в массиве равна {arr[indexMax] - arr[indexMin]}");
    }
}