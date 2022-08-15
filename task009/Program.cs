int n = new Random().Next(10, 100);

Console.WriteLine("Случайное число от 10 до 99: " + n);

int FirstDigit = n / 10;
int SecondDigit = n % 10;

if (FirstDigit > SecondDigit)
 {
    Console.WriteLine("Наибольшая цифра: " + FirstDigit);
}
else
{
    Console.WriteLine("Наибольшая цифра: " + SecondDigit);
}