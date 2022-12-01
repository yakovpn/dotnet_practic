//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

//Создание объекта для генерации чисел
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

void PrintIntArr(int[] arr)
{
    string arrStr = string.Empty;
    for (int i = 0; i < arr.Length; i++) arrStr += $"{arr[i]} ";
    arrStr = arrStr.Substring(0, arrStr.Length - 1);
    Console.WriteLine(arrStr);
}

int[] FillIntArr(int[] arr, int minValue, int maxValue)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = new Random().Next(minValue, maxValue + 1);
    return arr;
}

int arrLength = ReadInt("Введите длинну массива:", true, 1);
int minValue = ReadInt("Введите минимальное значение элемента массива:", true, 1);
int maxValue = ReadInt("Введите максимальное значение элемента массива:", true, 1);
int[] arr = FillIntArr(new int[arrLength], minValue, maxValue);
PrintIntArr(arr);
