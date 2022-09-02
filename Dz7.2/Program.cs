// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


Console.Write("Введите массив размера m:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите массив размера n:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите любое число массива s:  ");
int s = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [m,n];

 if (s > numbers.GetLength(0) || s > numbers.GetLength(1))
{
    Console.WriteLine("такой элемента элемента нет в массиве");
}
else
{
    Console.WriteLine("такой элемент элемента есть в массиве");
}

void FillArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
 }

void PrintArray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
 }

FillArray(numbers);
PrintArray(numbers);