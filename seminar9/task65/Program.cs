// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5-> "1, 2, 3, 4, 5"
// M = 4; N = 8-> "4, 5, 6, 7, 8"


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

void PrintMToN(int m, int n)
{
  if (n < m)
  {
    return;
  }
  else
  {
    PrintMToN(m, n - 1);
    Console.Write(n + " ");
  }
}

int m = ReadNumber("Введите число M: ");
int n = ReadNumber("Введите число N: ");
// Console.WriteLine(NumbersRec(m, n));
PrintMToN(m, n);