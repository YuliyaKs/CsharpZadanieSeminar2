// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
if (num < 0) num = -1 * num;
if (num < 100 || num > 999){
    Console.WriteLine("Введено неверное число");
}
else{
    Console.WriteLine($"Вторая цифра числа равна {(num / 10) % 10}");
}

