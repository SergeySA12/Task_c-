Console.Write("Введи число: n ");
int n = Convert.ToInt32(Console.ReadLine()); // n = любые числа
string nText = Convert.ToString(n);
if (nText.Length > 2)
{
  Console.WriteLine("Третья цифра данного числа" + nText[2]);
}
else 
{
  Console.WriteLine("Третьей цифры нет");
}