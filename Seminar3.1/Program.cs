// Напишите программу. которая принимает на вход число (А) и выдает сумму чисел от 1 до А

Console.WriteLine("Введи  число (n): ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= n; i++)
{
    sum = sum + i;
}
Console.WriteLine($"{sum}");