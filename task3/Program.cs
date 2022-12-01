/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет. Не использовать string[]. 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6. */

Console.WriteLine("Введите произвольное число");
bool isParset = int.TryParse(Console.ReadLine(), out int number);
if(!isParset)
{
    Console.WriteLine("Не является числом");
    return;
}
int deletingdigit = number;
if(deletingdigit < 100)
    {
        Console.WriteLine($"{number} -> третьей цифры нет");
        return;
    }
    while(deletingdigit >= 1000)
        {
            deletingdigit = deletingdigit / 10;    
        } 
Console.WriteLine($"{number} -> {deletingdigit = (deletingdigit % 10)}");






