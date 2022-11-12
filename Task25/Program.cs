/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int a = InputNum("Введите первое число: ");
int b = InputNum("Введите второе число: ");

int result = 1;

for(int i = 1; i <= b; i++)
{
    result *= a;
}

Console.Write($"{a} в {b} степени = {result}");


int InputNum(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}