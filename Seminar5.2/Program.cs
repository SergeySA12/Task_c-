// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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
int [] array = new int [8];

FillArray(array);
PrintArray(array);


Console.WriteLine("Введи  число : ");
int a = int.Parse(Console.ReadLine());


int var = 0;
for (int i = 0; i < array.Length; i++)
{
    if (a == array[i]);
    {
        Console.WriteLine($"Заданнное число присутсвует в массиве");
        var ++;
        break;
    }
}

if (var == 0)
{
    Console.WriteLine($"Заданнное число отуствует");
} 