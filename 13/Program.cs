// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

Console.Clear();
Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
if (num.Length < 3){
    Console.WriteLine("Третьей цифры нет");
}
else{
    Console.WriteLine($"Третья цифра числа равна {num[2]}");
}
