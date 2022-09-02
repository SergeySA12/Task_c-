// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Введите высоту матрицы:  ");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите длину матрицы:  ");
// int n = int.Parse(Console.ReadLine());

// int [,] array = new int[m,n];

//  void Fillarray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
//  }

// void Printarray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//  }

// Fillarray(array);
// Printarray(array);


// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Write("Введите массив размера m:  ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите массив размера n:  ");
int n = int.Parse(Console.ReadLine());

int [,] array = new int[m,n];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = i + j;
        }
    }
 

void Printarray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}  ");
        }
        Console.WriteLine();
    }
 }
 Printarray(array);