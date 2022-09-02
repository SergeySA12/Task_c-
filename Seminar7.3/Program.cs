// адача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали


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

int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j) temp = temp + array[i, j];
        }
    }

FillArray(array);

PrintArray(array);
Console.WriteLine($"Сумма диагоналей равна: {temp}");