﻿// Задача 16: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 != 0 && number2 !=0)
  {
    if (number1 / number2 == number2 || number2 / number1 == number1)
  {
    Console.WriteLine("Да. Одно из чисел является квадратом другого");
  }
  else
  {
    Console.WriteLine("Нет");
  }
  }
else
  {
    Console.WriteLine("Нельзя делить на 0!!!");
  }
