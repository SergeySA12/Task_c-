Console.Write("Введи  цифру дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7)
   {
  Console.WriteLine("Это выходной");
  }
  else if (dayNumber < 1 || dayNumber > 7)
   {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("Это не выходной день");
}

CheckingTheDayOfTheWeek(dayNumber);