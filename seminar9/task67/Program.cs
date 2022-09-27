// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int ReadNumber(string message)
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}


int SumDigits(int num) //Метод для подсчета суммы цифр в числе
{
  if (num / 10 == 0)
  {
    return num;
  }
  else
  {
    int sum = 0;
    sum += SumDigits(num / 10) + num % 10;
    return sum;
  }
}


int number = ReadNumber("Введите число: ");
int sum = SumDigits(number);
Console.WriteLine(sum);
