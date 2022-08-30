Console.WriteLine("Введите квадрат числа:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 == number2 * number2)
{
  Console.WriteLine("да");
}
else
{
  Console.WriteLine("нет");
}