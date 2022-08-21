// апишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16



Console.WriteLine("Введи  число (A): ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи  число (B): ");
int M = Convert.ToInt32(Console.ReadLine());
int result = 1;
  for (int i=1; i <= M; i++)
  {
    result = result * N;
  }
Console.WriteLine(result);