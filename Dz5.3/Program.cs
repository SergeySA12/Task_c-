// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// void FillArray (int [] arr)
// {
//     int length = arr.Length;
//     for (int i = 0; i < length; i++)
//     {
//         arr [i] = new Random().Next (-100,100);
//     }
// }

// void PrintArray (int [] arr)
// {
//     int length = arr.Length;
//     for (int i = 0; i < length; i++)
//     {
//         Console.Write($"{arr [i]} ");
//     }
// }
// int [] array = new int [5];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine();

//  for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = - array[i];
//     }

//     PrintArray(array);


double[] arrayNumbers = new double[5]  {3, 7, 22, 2, 78}; // Получаем нужные данные.
  for (int i = 0; i < arrayNumbers.Length; i++ )
  {
    // arrayNumbers[i] = new Random().Next(1, 10); Либо можно будет получить рандомные значения
    Console.Write(arrayNumbers[i] + " ");
  }

double maxNumber = arrayNumbers[0];
double minNumber = arrayNumbers[0];

  for (int i = 1; i < arrayNumbers.Length; i++)
  {
    if (maxNumber < arrayNumbers[i])
    {
      maxNumber = arrayNumbers[i];
    }
        if (minNumber > arrayNumbers[i])
    {
      minNumber = arrayNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");