﻿// Напишите программу, которая по заданному номеру четверти
// показывает диапазон возможных координатных точек в этой четверти (x y)

Console.Write("Введи  номер четверти (от 1 до 4): ");
//int - count = 0;
//while (count < 5);
int x = int.Parse(Console.ReadLine());

string [] q1 = {" X > 0, Y > 0", " X < 0, Y > 0", " X < 0, Y < 0", " X > 0, Y < 0"};
Console.WriteLine(" Диапазон значений для четверти" + x + "равен" + q1 [x-1]);