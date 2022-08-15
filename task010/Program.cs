int n = new Random().Next(100, 999);

Console.WriteLine(n);

int FirstDigit = n / 100;
int SecondDigit = n % 10;

Console.WriteLine(FirstDigit * 10 + SecondDigit);
