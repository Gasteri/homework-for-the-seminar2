/* Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, 
является ли этот день выходным.6 -> да, 7 -> да, 1 -> нет. */

Console.WriteLine("Введите цифру от 1 до 7");
bool isParset = int.TryParse(Console.ReadLine(), out int number);
if(!isParset)
{
    Console.WriteLine("Не является числом");
    return;
}

if(number == 6 | number == 7)
{
    Console.WriteLine($"{number} -> Да");
}
else
{
    Console.WriteLine($"{number} -> Нет");
}