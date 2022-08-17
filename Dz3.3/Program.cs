// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine("Введи число N: ");
int N = int.Parse(Console.ReadLine());
int index = 1;
 while ( index <= Math.Abs(N))
 {
Console.Write($"{index * index * index}, ");
index ++;
 }
 
 