// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

void FillArray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr [i] = new Random().Next (-100,100);
    }
}

void PrintArray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arr [i]} ");
    }
}
int [] array = new int [4];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 != 0);
    {
        sum = sum + array[i];
    }
}
Console.WriteLine("сумма нечетных элемнтов массива");
Console.WriteLine(sum);
// int count = 0;
//  foreach(int i in array)
//             {
//                 if (i % 2 == 0)
//                 {
//                     count++;
//                 }
//             }
//             Console.WriteLine();
//             Console.WriteLine("Количество четных элементов {0}", count);
