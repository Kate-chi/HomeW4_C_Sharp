/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 0) num = -num;

int result = 0;

while(num > 0)
{
    result += num % 10;
    num /= 10;
}

Console.Write($"Сумма цифр вашего числа = {result}");