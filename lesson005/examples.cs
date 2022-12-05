using DotNetPractic;
public partial class lesson005
{
    // Напишите программу замена элементов массива:
    // положительные элементы замените на соответствующие
    // отрицательные, и наоборот.
    // [-4, -8, 8, 2] -> [4, 8, -8, -2] 
    public void exampleBody1()
    {
        int[] arr = DNPTools.FillIntArr(new int[12], -99, 99);
        Console.WriteLine($"Сформирован массив:[{DNPTools.ArrToStr(arr)}]");
        for (int i = 0; i < arr.Length; i++) arr[i] = -arr[i];
        Console.WriteLine($"Результат после смены занков всех элементов:[{DNPTools.ArrToStr(arr)}]");
    }
    // Задайте массив. Напишите программу, которая
    // определяет, присутствует ли заданное число в массиве.
    // 4; массив [6, 7, 19, 345, 3] -> нет
    // 3; массив [6, 7, 19, 345, 3] -> да
    public void exampleBody2()
    {
        int a = DNPTools.ReadInt("Введите значение элемента для поиска:", true, -999, 999);
        int[] arr = DNPTools.FillIntArr(new int[100], -999, 999);
        Console.WriteLine($"Сформирован массив:[{DNPTools.ArrToStr(arr)}]");
        bool b = false;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == a)
            {
                b = true;
                break;
            }
        }
        string msg = b ? "Найдено" : "Не найдено";
        Console.WriteLine($"В массиве значение {a} {msg}");
    }
    // Задайте одномерный массив из 123 случайных чисел.
    // Найдите количество элементов массива, значения которых лежат в
    // отрезке [10,99].
    // Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
    // 123
    // [5, 18, 123, 6, 2] -> 1
    // [1, 2, 3, 6, 2] -> 0
    // [10, 11, 12, 13, 14] -> 5
    public void exampleBody3()
    {
        int[] arr = DNPTools.FillIntArr(new int[123], -100, 100);
        Console.WriteLine($"Сформирован массив:[{DNPTools.ArrToStr(arr)}]");
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 10 && arr[i] <= 99) count++;
        }
        Console.WriteLine($"Количество найденных значений в отрезке [10,99]:{count}");

    }
    // Найдите произведение пар чисел в одномерном массиве.
    // Парой считаем первый и последний элемент, второй и предпоследний
    // и т.д. Результат запишите в новом массиве.
    // [1 2 3 4 5] -> 5 8 3
    // [6 7 3 6] -> 36 21
    public void exampleBody4()
    {
        int arrLength = DNPTools.ReadInt("Введите длинну массива:", true);
        int[] arr = DNPTools.FillIntArr(new int[arrLength], 0, 99);
        Console.WriteLine($"Сформирован массив:[{DNPTools.ArrToStr(arr)}]");
        int[] resArr = new int[arr.Length % 2 > 0 ? arr.Length / 2 + 1 : arr.Length / 2];
        for (int i = 0; i < resArr.Length; i++)
        {
            resArr[i] = (i == resArr.Length - 1 && arr.Length % 2 > 0) ? arr[i] : arr[i] * arr[arr.Length - (i + 1)];

        }
        DNPTools.PrintArr(resArr);

    }
}
