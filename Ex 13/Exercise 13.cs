/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Решаем с помощью "/" и "%", со строками не работаем (Максимальное число 100000) */

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()!);
int num3 = 0;
int max = 100000;
int min = 0;


if (num > max || num < min)
{
    Console.WriteLine($"Число {num} находится за рамками заданного диапозона от '{min}' до '{max}'");
}
else
{
    if (num < 100)
    {
        Console.WriteLine($"В числе {num} нет третьей цирфы");
    }
    else
    {
        if (num >= 100 && num < 999) 
        {
            num3 = num % 10;
        }  
        if (num >= 1000 && num < 9999) 
        {
            num3 = num / 10 % 10;
        }
        if (num >= 10000 && num < 99999) 
        {
            num3 = num / 100 % 10;
        }
        if (num >= 100000 && num < 999999) 
        {
            num3 = num / 1000 % 10;
        }
   
        Console.WriteLine($"В числе {num} третьей цифрой является '{num3}'");
    }
}