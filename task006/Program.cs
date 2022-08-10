Console.WriteLine("Введите первое целое число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое число");
int z = Convert.ToInt32(Console.ReadLine());

int max = n;

if (n > max) max = n;
if (m > max) max = m;
if (z > max) max = z;

Console.Write("max = ");
Console.WriteLine(max);