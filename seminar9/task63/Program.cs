// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

int ReadNumber(string message)
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}

string NumbersRec(int a, int n)
{
  if (n >= a)
  {
    return $"{a} " + NumbersRec(a + 1, n);
  }
  else return string.Empty;
}

void PrintToN(int n)
{
  if (n <= 0)
  {
    return;
  }
  else
  {
    PrintToN(n - 1);
    Console.Write(n + " ");
  }
}

int n = ReadNumber("Введите число N: ");
// int a = 1;
// Console.WriteLine(NumbersRec(a, n));
PrintToN(n);