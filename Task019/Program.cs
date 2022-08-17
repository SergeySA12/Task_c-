// Напишите программу, которая принимает на вход число (N)
// и выдает таблицу квадратов от 1 до N
// 5
// 2


Console.WriteLine("Введи число N: ");
int N = int.Parse(Console.ReadLine());
int index = 1;
 while ( index <= Math.Abs(N))
 {
Console.Write($"{index * index}, ");
index ++;
 }
 
 