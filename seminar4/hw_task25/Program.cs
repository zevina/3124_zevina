// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

int ReadNumber(string message) //Метод для ввода числа из консоли
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}

int ExpNumbers(int A, int B) //Метод для возведения числа А в степень числа В
{
  if (B > 0)
  {
    int result = A;
    for (int i = 1; i < B; i++)
    {
      result = result * A;
    }
    return result;
  }
  else
  {
    return -1;
  }
}

int numberA = ReadNumber("Введите число (А): ");
int numberB = ReadNumber("Введите степень (В): ");
int exp = ExpNumbers(numberA, numberB);

if (exp == -1)
{
  Console.WriteLine("Степень должна быть натуральным числом!");
}
else
{
  Console.WriteLine($"Число {numberA} в степени {numberB}: ");
Console.WriteLine(exp);
}
