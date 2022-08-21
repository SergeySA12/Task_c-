// Напишите программу. которая массив из 8 элементов. заполненый нулями и единицами в случайном порядке.

int[] mass = new int[8];
int i = 0;
while ( i < mass.Length)
{
    mass[i] = new Random().Next(0,2);
    Console.Write(mass[i]);
    i++;
}