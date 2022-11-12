/*
Задача 29: Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int [size];

PrintArr(array);
Console.WriteLine();
FillArr(array);
PrintArr(array);

void FillArr(int[] arr)
{
    for(int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
}

void PrintArr(int[] arr)
{
    Console.Write("[");

    for(int i = 0; i < size; i++)
    {
        Console.Write(arr[i]);

        if(i < size - 1)
        {
            Console.Write(", ");
        }
    }

    Console.Write("]");
}