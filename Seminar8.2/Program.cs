// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 123456142536




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

int[,] Transveste(int[,] arr)
{
    int[,] arr1 = new int[n,m];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arr1[j,i] = array [i,j];
        }
    }
    return arr1;
}


FillPrint2DArray(array);
Print2DArray(Transveste(array));