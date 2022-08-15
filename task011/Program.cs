int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());

if(n % m == 0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Остаток" + n % m);
}
