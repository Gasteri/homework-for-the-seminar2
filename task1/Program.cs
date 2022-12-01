/*  Напишите программу, которая принимает на вход трёхзначное 
    число и на выходе показывает вторую цифру этого числа.456 -> 5, 782 -> 8, 918 -> 1  */

Console.WriteLine("Введите трехзначное число");
bool isParset = int.TryParse(Console.ReadLine(), out int number);
if(!isParset)
{
    Console.WriteLine("Не является числом");
    return;
}
int secondDigit = (number / 10) % 10;
Console.WriteLine($"{number} -> {secondDigit}");
