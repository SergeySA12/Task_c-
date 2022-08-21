// Напишите программу. которая принимает на вход число (А) и выдает количество цифр в числе.

Console.Write("Введи число: n ");
int n =  Math.Abs(Convert.ToInt32(Console.ReadLine())); // n = любые числа
int count = 0;
while (n != 0)
{
    count++;
    n = n / 10;
}
Console.WriteLine($" в числе {count} цифр");