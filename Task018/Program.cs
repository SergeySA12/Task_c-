// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
// A(3,6); B(2,1)
// A(7,-5); B(1-1)




Console.WriteLine("Введи  А координату: ");
int ax = int.Parse(Console.ReadLine());
int ay = int.Parse(Console.ReadLine());
Console.WriteLine("Введи  B координату: ");
int bx = int.Parse(Console.ReadLine());
int by = int.Parse(Console.ReadLine());

Console.WriteLine(ax - bx);
Console.WriteLine(ay - by);
double AB = Math.Sqrt(Math.Pow(ax - bx,2) + Math.Pow(ay - by,2));

Console.WriteLine(AB);