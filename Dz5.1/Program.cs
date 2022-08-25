//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


void FillArray (int [] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr [i] = new Random().Next (100,999);
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

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0);
    {
        count ++;
    }
}
Console.WriteLine("Кол-во четных элементов в массиве");
Console.WriteLine(count);
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
