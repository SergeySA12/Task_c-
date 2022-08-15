Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

if ((n / m ==m)^(m / n ==n))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Не является");

}