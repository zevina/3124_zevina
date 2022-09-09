// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadNumber(string message) //Метод для ввода числа из консоли
{
  Console.WriteLine(message);
  return Convert.ToInt32(Console.ReadLine());
}

// int CountDigits(int number)
// {
//   if (Math.Abs(number) > 9)
//   {
//     int count = 0;
//     while (Math.Abs(number) > 9)
//         {
//           number = number /10;
//           count ++;
//         }
//     return count+1;
//   }
//   else return 1;
// }

int CountDigits(int number)
{
    int count = 0;
    while (number != 0)
        {
          number = number /10;
          count ++;
        }
    return count;
}

int number = ReadNumber("Введите число: ");
int count = CountDigits(number);
Console.WriteLine($"Количество цифр в числе {number}: {count} ");