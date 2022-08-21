// Напишите программу. которая принимает на вход число (А) и выдает произведение чисел от 1 до А

Console.WriteLine("Введи число: n ");
int n =  Convert.ToInt32(Console.ReadLine());
int count = 1;
for (int i = 2; i <= n; i++)
{
    count = count * i;
}
Console.WriteLine(count);