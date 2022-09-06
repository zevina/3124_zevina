// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер координатной четверти (1-4): ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >=1 && number <=4)
{
  if (number == 1)
  {
    Console.WriteLine("Диапазон значений для координат:");
    Console.WriteLine("x > 0, y > 0");
  }
  else if (number == 2)
  {
    Console.WriteLine("Диапазон значений для координат:");
    Console.WriteLine("x < 0, y > 0");
  }
    else if (number == 3)
  {
    Console.WriteLine("Диапазон значений для координат:");
    Console.WriteLine("x < 0, y < 0");
  }
    else if (number == 4)
  {
    Console.WriteLine("Диапазон значений для координат:");
    Console.WriteLine("x > 0, y < 0");
  }
}
else
{
  Console.WriteLine("Номер четверти введен некорректно!");
}