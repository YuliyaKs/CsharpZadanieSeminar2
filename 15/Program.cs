// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.Write("Введите номер дня недели: ");
int DayOfWeek = int.Parse(Console.ReadLine());
if (DayOfWeek < 1 || DayOfWeek > 7){
    Console.Write("Введен неправильный номер");
}
else if (DayOfWeek == 6 || DayOfWeek == 7){
    Console.Write($"ДА! День недели номер {DayOfWeek} - выходной");
}
else {
    Console.Write($"НЕТ! День недели номер {DayOfWeek} не является выходным днем");
}