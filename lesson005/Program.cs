﻿using DotNetPractic;
int exampleType = DNPTools.ReadInt("Выберите пример на уроке (1) домшнее задаение (2) :", true, 1, 2);
int exampleNumber = DNPTools.ReadInt("Введите номер примера:", true, 1, 10);
string exampleMethodName = exampleType == 2 ? $"homeWorkBody{exampleNumber}" : $"exampleBody{exampleNumber}";
string exampleName = exampleType == 2 ? $"Домашнее задание #{exampleNumber}" : $"Пример на уроке #{exampleNumber}";
lesson005 lsn5 = new lesson005();

// Поиск и запуск метода в классе Lesson005
var exampleMethodBody = lsn5.GetType().GetMethod(exampleMethodName);
if (exampleMethodBody != null) {
    Console.WriteLine($"=========== {exampleName} ===========");
    exampleMethodBody.Invoke(lsn5, parameters: null);
}
else
    Console.WriteLine("Нет такого примера");
