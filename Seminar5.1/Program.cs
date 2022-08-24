// Напишите программу замена элементов массива; положительные элементы
// замените на соотвествующие отрицательные
// (-4. -8. 8. 2) -> (4. 8. -8. -2)

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
int [] array = new int [5];

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();

 for (int i = 0; i < array.Length; i++)
    {
        array[i] = - array[i];
    }

    PrintArray(array);