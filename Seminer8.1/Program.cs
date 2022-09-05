// // Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива

// Console.WriteLine("Введите высоту матрицы:  ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите длину матрицы:  ");
// int n = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int[m,n];

//  void FillArray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
//  }

// void PrintArray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//  }

// FillArray(array);
// PrintArray(array);

// for (int j = 0; j < array.GetLength(1) - 1; j++)
//     {
//         int temp = 0;
//         temp = array[0,j];
//         array[0,j] = array[array.GetLength(0) - 1, j];
//         array[array.GetLength(0) - 1, j] = temp;
//     }
//  Console.WriteLine();
// Console.WriteLine();

// FillArray(array);
// Console.WriteLine();
// PrintArray(array);


Console.Clear();

int m = Convert.ToInt32(new Random().Next(3, 5)); // Randomly select how many rows will be in array
int n = m + Convert.ToInt32(new Random().Next(3, 5)); //Randomly select how many columns will be in array, which is larger than m
Console.WriteLine();

int[,] array = new int[m, n];


void FillPrint2DArray(int[,] arr) // Randomly fill out 2D array with integers and print it to the terminal
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
arr[i, j] = new Random().Next(-10, 11);
if (arr[i, j] < 0) Console.Write(arr[i, j] + " ");
else Console.Write(" " + arr[i, j] + " ");
}
Console.WriteLine();
Console.WriteLine();
}
Console.WriteLine();
}
void Swap(int[,] arr)
{
for (int j = 0; j < arr.GetLength(1) - 1; j++)
{
int temp = 0;
temp = arr[0, j];
arr[0, j] = arr[arr.GetLength(0) - 1, j];
arr[arr.GetLength(0) - 1, j] = temp;
}
}

void Print2DArray(int[,] arr) // Print 2D array with tab as columns delimiter.
{
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j < arr.GetLength(1); j++)
{
if (arr[i, j] < 0) Console.Write(arr[i, j] + " ");
else Console.Write(" " + arr[i, j] + " ");
}
Console.WriteLine();
Console.WriteLine();
}
Console.WriteLine();
}

FillPrint2DArray(array);
Swap(array);
Console.WriteLine();
Print2DArray(array);