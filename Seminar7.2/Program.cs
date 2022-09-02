// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


Console.WriteLine("Введите высоту матрицы:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину матрицы:  ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] array = new int[m,n];

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

void sqrt(int[,] array){
    for (int i = 0; i < array.GetLength(0); i+=2)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            array[i,j] = array[i,j] * array[i,j];
        }
    }
 }

FillArray(array);

PrintArray(array);
sqrt(array);
Console.WriteLine();
PrintArray(array);