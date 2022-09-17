// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
// 67 -> 1000011

void SystemChange(int number, int A)
{
 if (number !=0)
 {
  SystemChange(number/A, A);
  Console.Write(number%A);
 }
}

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите основание системы (двоичная, восьмиричная ...):");
int numberA = Convert.ToInt32(Console.ReadLine());

SystemChange(number, numberA);
