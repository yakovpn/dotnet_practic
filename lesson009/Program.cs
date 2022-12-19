using DotNetPractic;
int exampleType = DNPTools.ReadInt("Выберите пример на уроке (1) домшнее задаение (2) :", true, 1, 2);
int exampleNumber = DNPTools.ReadInt("Введите номер примера:", true, 1, 10);
string exampleMethodName = exampleType == 2 ? $"homeWorkBody{exampleNumber}" : $"exampleBody{exampleNumber}";
string exampleName = exampleType == 2 ? $"Домашнее задание #{exampleNumber}" : $"Пример на уроке #{exampleNumber}";
lesson009 lsn = new lesson009();

// Поиск и запуск метода в классе Lesson009
var exampleMethodBody = lsn.GetType().GetMethod(exampleMethodName);
if (exampleMethodBody != null) {
    Console.WriteLine($"=========== {exampleName} ===========");
    exampleMethodBody.Invoke(lsn, parameters: null);
}
else
    Console.WriteLine("Нет такого примера");
